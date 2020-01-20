using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RecepcióComandes
{
    public class CrearTreeNode
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public CrearTreeNode(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        public TreeNode CreateDirectoryNode(string path, string name)
        {
            TreeNode directoryNode = new TreeNode(name);

            foreach (FTPListDetail dir in GetDirectoryListing(path).Where(d => d.IsDirectory))
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(dir.FullPath, dir.Name));
            }
            foreach (FTPListDetail file in GetDirectoryListing(path).Where(d => !d.IsDirectory))
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name).ToString(), file.Name.ToString(), 1, 1);
            }
            return directoryNode;
        }

        private List<FTPListDetail> GetDirectoryListing(string path)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest request = GetWebRequest(WebRequestMethods.Ftp.ListDirectoryDetails, path);
                using (var response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
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
                        string[] results = result.ToString().Split('\n');
                        string regex =
                            @"^" +                          //# Start of line
                            @"(?<dir>[\-ld])" +             //# File size          
                            @"(?<permission>[\-rwx]{9})" +  //# Whitespace          
                            @"\s+" +                        //# Whitespace          
                            @"(?<filecode>\d+)" +
                            @"\s+" +                        //# Whitespace          
                            @"(?<owner>\w+)" +
                            @"\s+" +                        //# Whitespace          
                            @"(?<group>\w+)" +
                            @"\s+" +                        //# Whitespace          
                            @"(?<size>\d+)" +
                            @"\s+" +                        //# Whitespace          
                            @"(?<month>\w{3})" +            //# Month (3 letters)   
                            @"\s+" +                        //# Whitespace          
                            @"(?<day>\d{1,2})" +            //# Day (1 or 2 digits) 
                            @"\s+" +                        //# Whitespace          
                            @"(?<timeyear>[\d:]{4,5})" +    //# Time or year        
                            @"\s+" +                        //# Whitespace          
                            @"(?<filename>(.*))" +          //# Filename            
                            @"$";                           //# End of line

                        List<FTPListDetail> myresult = new List<FTPListDetail>();
                        foreach (var parsed in results)
                        {
                            Match split = new Regex(regex).Match(parsed);
                            string dir = split.Groups["dir"].ToString();
                            string permission = split.Groups["permission"].ToString();
                            string filecode = split.Groups["filecode"].ToString();
                            string owner = split.Groups["owner"].ToString();
                            string group = split.Groups["group"].ToString();
                            string filename = split.Groups["filename"].ToString();
                            myresult.Add(new FTPListDetail()
                            {
                                Dir = dir,
                                Filecode = filecode,
                                Group = group,
                                FullPath = path + "/" + filename,
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

        private FtpWebRequest GetWebRequest(string method, string path)
        {
            Uri serverUri = new Uri(path);
            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                return null;
            }
            FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(serverUri);
            reqFTP.Method = method;
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(userName, passWord);
            reqFTP.Proxy = null;
            reqFTP.KeepAlive = false;
            reqFTP.UsePassive = false;
            return reqFTP;
        }
    }
}
