using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcióComandes
{
    public class gestionServidorFTP
    {

        //Obtener la ruta completa del nodo seleccionado en el TreeView 
        public static string GetCurrentNodeName(TreeView VisorArchivos)
        {
            string name;

            try
            {
                name = VisorArchivos.SelectedNode.FullPath.Substring(1);
            }
            catch
            {
                return null;
            }
            return name;
        }
        //Función para descargar archivos
        public static void DescargarArchivo(string ipServidor, string userName, string password, TreeView VisorArchivos)
        {
            try
            {
                FtpWebRequest DescargarArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + GetCurrentNodeName(VisorArchivos));
                DescargarArchivo.Credentials = new NetworkCredential(userName, password);
                DescargarArchivo.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse ftpResponse = (FtpWebResponse)DescargarArchivo.GetResponse();
                //Stream ftpResponseStream = ftpResponse.GetResponseStream();
                ftpResponse.Close();
            }
            catch
            { }

        }

        //Función para crear una carpeta en el servidor FTP
        public static void CrearCarpetaFTP(string ipServidor, string userName, string password, TreeView VisorArchivos)
        {
            string NombreCampo = Microsoft.VisualBasic.Interaction.InputBox("Escriba el nombre de la carpeta.", "Crear carpeta");

            if (!(NombreCampo.Trim() == "" || VisorArchivos.SelectedNode.SelectedImageIndex == 1))
            {
                VisorArchivos.SelectedNode.Nodes.Add(NombreCampo);

                try
                {
                    FtpWebRequest CrearCarpeta = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + GetCurrentNodeName(VisorArchivos) + "/" + NombreCampo);
                    CrearCarpeta.Credentials = new NetworkCredential(userName, password);
                    CrearCarpeta.Method = WebRequestMethods.Ftp.MakeDirectory;
                    FtpWebResponse ftpResponse = (FtpWebResponse)CrearCarpeta.GetResponse();
                }
                catch
                { }
            }
        }

        //Funcion para subir un archivo
        public static void SubirArchivo(string rutaAbsolutaArchivo, string nombreArchivo, string ipServidor, string userName, string password, TreeView VisorArchivos)
        {
            try
            {
                FtpWebRequest SubirArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + GetCurrentNodeName(VisorArchivos) + "/" + nombreArchivo);
                SubirArchivo.Credentials = new NetworkCredential(userName, password);
                SubirArchivo.Method = WebRequestMethods.Ftp.UploadFile;
                FtpWebResponse ftpResponse = (FtpWebResponse)SubirArchivo.GetResponse();

                using (Stream fileStream = File.OpenRead(rutaAbsolutaArchivo))
                using (Stream ftpStream = SubirArchivo.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }
            }
            catch
            { }
        }

        //Explorador archivos para subir al servidor      
        public static void AbrirExploradorSubirArchivos(OpenFileDialog ExploradorArchivos, string ipServidor, string userName, string password, TreeView VisorArchivos)
        {
            string RutaArchivo;
            
            ExploradorArchivos.InitialDirectory = "C:\\";
            ExploradorArchivos.Filter = "Archivos EDI (*.EDI)|*.EDI|All files (*.*)|*.*";
            ExploradorArchivos.FilterIndex = 0;
            ExploradorArchivos.RestoreDirectory = true;

            if (ExploradorArchivos.ShowDialog() == DialogResult.OK)
            {
                RutaArchivo = ExploradorArchivos.FileName;
                SubirArchivo(RutaArchivo, ExploradorArchivos.SafeFileName, ipServidor, userName, password, VisorArchivos);
            }
        }

        //Borrar carpetas y archivos
        public static void BorrarDirArchivo(string RutaAbsolutaDirectorio, string ipServidor, string userName, string password, TreeView VisorArchivos)
        {
            try
            {
                FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(RutaAbsolutaDirectorio);
                listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                listRequest.Credentials = new NetworkCredential(userName, password);

                List<string> lines = new List<string>();

                using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
                using (Stream listStream = listResponse.GetResponseStream())
                using (StreamReader listReader = new StreamReader(listStream))
                {
                    while (!listReader.EndOfStream)
                    {
                        lines.Add(listReader.ReadLine());
                    }
                }

                foreach (string line in lines)
                {
                    string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[8];
                    string permissions = tokens[0];

                    string fileUrl = RutaAbsolutaDirectorio + name;

                    if (permissions[0] == 'd')
                    {
                        BorrarDirArchivo(fileUrl + "/", ipServidor, userName, password, VisorArchivos);
                    }
                    else
                    {
                        FtpWebRequest deleteRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                        deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                        deleteRequest.Credentials = new NetworkCredential(userName, password);

                        deleteRequest.GetResponse();
                    }
                }

                FtpWebRequest removeRequest = (FtpWebRequest)WebRequest.Create(RutaAbsolutaDirectorio);
                removeRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;
                removeRequest.Credentials = new NetworkCredential(userName, password);

                removeRequest.GetResponse();
            }
            catch
            {
                try
                {
                    FtpWebRequest BorrarArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + GetCurrentNodeName(VisorArchivos));
                    BorrarArchivo.Credentials = new NetworkCredential(userName, password);
                    BorrarArchivo.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse ftpResponse = (FtpWebResponse)BorrarArchivo.GetResponse();
                }
                catch (Exception)
                { }
            }
        }
    }
}
