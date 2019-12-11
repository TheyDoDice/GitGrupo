using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ConsolaGestionFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "FTP Files Downloader";
            MostrarDatosServer(args);
        }

        private static void MostrarDatosServer(string[] arguments)
        {
            try
            {
               /* string[] test = new string[]
                {
                    "172.17.6.0",
                    "g02",
                    "12345aA",
                    "C:\\Users\\admin\\Desktop\\GitGrupo\\Proyectos\\Descargas",
                    "/Hola/",
                    "/Tractats/"
                };*/

                List<string> FileList = new List<string>();
                Console.WriteLine("Datos del servidor:\n");
                Console.WriteLine("Servidor: {0}\nUsuario: {1}\nContraseña: {2}\nCarpeta Descargas: {3}\nRuta Descargas: {4}", arguments[0], arguments[1], OcultarContraseña(arguments[2], '*'), arguments[3], arguments[4]);
                Console.WriteLine("\nBuscando archivos en el servidor...");
                FileList = ListarArchivos(arguments[0], arguments[1], arguments[2], arguments[4]);
                foreach (string item in FileList)
                {
                    DescargarArchivo(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], item);
                    FtpRename(arguments[1], arguments[2], "ftp://" + arguments[0] + arguments[4] + item, arguments[5], item);
                    Console.Write("Descargando {0} en la carpeta {1}\n", item.Substring(item.IndexOf("/") + 1), arguments[3]);
                }
                CerrarConsola();
            }
            catch
            {
                Console.WriteLine("Error, faltan los datos de conexión");
                CerrarConsola();
            }
        }

        private static void CerrarConsola()
        {
            Console.WriteLine("Presiona una tecla para cerrar la consola.");
            Console.ReadKey();
        }

        private static string OcultarContraseña(string input, char target)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(target);
            }

            return sb.ToString();
        }

        //Listar archvios del servidor FTP
        public static List<string> ListarArchivos (string ipServidor, string userName, string password, string directorio)
        {
            List<string> ListaTemporal = new List<string>();
            List<string> listaArchivos = new List<string>();
            FtpWebRequest ListarDirectorio = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + directorio );
            ListarDirectorio.Credentials = new NetworkCredential(userName, password);
            ListarDirectorio.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            WebResponse listResponse = ListarDirectorio.GetResponse();
            Stream listStream = listResponse.GetResponseStream();
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    string line = listReader.ReadLine();
                    ListaTemporal.Add(line);
                }
            }

            foreach (string line in ListaTemporal)
            {
                string[] tokens =
                    line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                if (permissions[0] == 'd')
                {
                   // Console.WriteLine($"Directory {name}");
                    ListarArchivos(ipServidor,userName,password, "/" + name);
                }
                else
                {
                    Console.WriteLine($"File {name}");
                    listaArchivos.Add(name);
                }
            }

            return listaArchivos;
        }

        //Función para descargar archivos
        public static void DescargarArchivo(string ipServidor, string userName, string password, string RutaLocal, string rutaArchivo, string nombreArchivo)
        {
            try
            {
                FtpWebRequest DescargarArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + rutaArchivo + nombreArchivo);
                DescargarArchivo.Credentials = new NetworkCredential(userName, password);
                DescargarArchivo.Method = WebRequestMethods.Ftp.DownloadFile;
                using (Stream ftpStream = DescargarArchivo.GetResponse().GetResponseStream())
                try
                {
                    using (Stream fileStream = File.Create(RutaLocal + "\\" + nombreArchivo))
                    {
                        ftpStream.CopyTo(fileStream);
                    }
                }
                catch
                {}
            }
            catch
            { }

        }

        //Mover archivos del servidor FTP
        public static void FtpRename(string userName, string password, string origen, string carpeta_destino, string nombre_archivo)
        {
            try
            {
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(origen);
                reqFTP.Credentials = new NetworkCredential(userName, password);
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = carpeta_destino + nombre_archivo;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                reqFTP.GetResponse().Close();
            }
            catch { }

        }
    }
}
