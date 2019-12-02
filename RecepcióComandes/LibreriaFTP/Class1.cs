using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LibreriaFTP
{
    public class FTP
    {
        public TreeNode CrearArbol(string CadenaConnexion, string NombrePrimerNodo, string UsuarioFTP, string ContraseñaFTP)
        {
            var directoryNode = new TreeNode(CadenaConnexion);
            var directoryListing = ObtenerListadoDirectorios(NombrePrimerNodo, UsuarioFTP, ContraseñaFTP);

            var directories = directoryListing.Where(d => d.IsDirectory);
            var files = directoryListing.Where(d => !d.IsDirectory);

            foreach (var dir in directories)
            {
                directoryNode.Nodes.Add(CrearArbol(dir.FullPath, dir.Name, UsuarioFTP, ContraseñaFTP));
            }
            foreach (var file in files)
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name).ToString(), file.Name.ToString(), 1, 1);
            }
            return directoryNode;
        }

        public IEnumerable<FTPListDetail> ObtenerListadoDirectorios(string CadenaConnexion, string UsuarioFTP, string ContraseñaFTP)
        {
            try
            {
                var CurrentRemoteDirectory = CadenaConnexion;
                var result = new StringBuilder();
                var request = GetWebRequest(WebRequestMethods.Ftp.ListDirectoryDetails, CurrentRemoteDirectory, UsuarioFTP, ContraseñaFTP);
                using (var response = request.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            result.Append(line);
                            result.Append("\n");
                            line = reader.ReadLine();
                        }
                        if (string.IsNullOrEmpty(result.ToString()))
                        {
                            return new List<FTPListDetail>();
                        }
                        result.Remove(result.ToString().LastIndexOf("\n"), 1);
                        var results = result.ToString().Split('\n');
                        string regex =
                            @"^" +               //# Start of line
                            @"(?<dir>[\-ld])" +          //# File size          
                            @"(?<permission>[\-rwx]{9})" +            //# Whitespace          \n
                            @"\s+" +            //# Whitespace          \n
                            @"(?<filecode>\d+)" +
                            @"\s+" +            //# Whitespace          \n
                            @"(?<owner>\w+)" +
                            @"\s+" +            //# Whitespace          \n
                            @"(?<group>\w+)" +
                            @"\s+" +            //# Whitespace          \n
                            @"(?<size>\d+)" +
                            @"\s+" +            //# Whitespace          \n
                            @"(?<month>\w{3})" +          //# Month (3 letters)   \n
                            @"\s+" +            //# Whitespace          \n
                            @"(?<day>\d{1,2})" +        //# Day (1 or 2 digits) \n
                            @"\s+" +            //# Whitespace          \n
                            @"(?<timeyear>[\d:]{4,5})" +     //# Time or year        \n
                            @"\s+" +            //# Whitespace          \n
                            @"(?<filename>(.*))" +            //# Filename            \n
                            @"$";                //# End of line

                        var myresult = new List<FTPListDetail>();
                        foreach (var parsed in results)
                        {
                            var split = new Regex(regex)
                                .Match(parsed);
                            var dir = split.Groups["dir"].ToString();
                            var permission = split.Groups["permission"].ToString();
                            var filecode = split.Groups["filecode"].ToString();
                            var owner = split.Groups["owner"].ToString();
                            var group = split.Groups["group"].ToString();
                            var filename = split.Groups["filename"].ToString();
                            myresult.Add(new FTPListDetail()
                            {
                                Dir = dir,
                                Filecode = filecode,
                                Group = group,
                                FullPath = CurrentRemoteDirectory + "/" + filename,
                                Name = filename,
                                Owner = owner,
                                Permission = permission,
                            });
                        };
                        return myresult;
                    }
                }
            }
            catch
            {
                return new List<FTPListDetail>();
            }
        }

        public FtpWebRequest GetWebRequest(string method, string CadenaConnexion, string UsuarioFTP, string ContraseñaFTP)
        {
            Uri serverUri = new Uri(CadenaConnexion);
            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                return null;
            }
            var reqFTP = (FtpWebRequest)FtpWebRequest.Create(serverUri);
            reqFTP.Method = method;
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(UsuarioFTP, ContraseñaFTP);
            reqFTP.Proxy = null;
            reqFTP.KeepAlive = false;
            reqFTP.UsePassive = false;
            return reqFTP;
        }

        public void ActualizarArbol(TreeView Arbol, string NombrePrimerNodo, string CadenaConnexion, string UsuarioFTP, string ContraseñaFTP)
        {
            Arbol.BeginUpdate();
            Arbol.Nodes.Clear();
            Arbol.Nodes.Add(CrearArbol(CadenaConnexion, NombrePrimerNodo, UsuarioFTP, ContraseñaFTP));
            Arbol.EndUpdate();
        }
    }

    public class FTPListDetail
    {
        public bool IsDirectory
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Dir) && Dir.ToLower().Equals("d");
            }
        }

        internal string Dir { get; set; }
        public string Permission { get; set; }
        public string Filecode { get; set; }
        public string Owner { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
    }
}
