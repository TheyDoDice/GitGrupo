using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ConsolaGestionFTP
{
    class Program
    {
        //Descarga de la raiz del servidor FTP y lo mueve a la carpeta /tractats.
        //se guarda en la carpeta elegida para guardar descargas, con el FileSystemWatcher Clase se mira si se 
        //ha modificado la carpeta procesa los archivos y lo vuelve a subir a la raiz del servidor FTP.
        //Para subir no se usa la consola, lo hace el mismo programa.

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
                string[] test = new string[]
                {
                    "172.17.6.0",
                    "g02",
                    "12345aA",
                    "C:\\Users\\admin\\Desktop\\GitGrupo\\Proyectos\\Descargas"
                };

                List<string> FileList = new List<string>();
                Console.WriteLine("Datos del servidor:\n");
                Console.WriteLine("Servidor: {0}\nUsuario: {1}\nContraseña: {2}\n", test[0], test[1], OcultarContraseña(test[2], '*'));
                Console.WriteLine("\nBuscando archivos en el servidor...");
                FileList = ListarArchivos(test[0], test[1], test[2], "/");
                foreach (string item in FileList)
                {
                    DescargarArchivo(test[0], test[1], test[2], test[3], item);
                    Console.Write("Descargando {0} en la carpeta {1}\n", item.Substring(item.IndexOf("/") + 1), test[3]);
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
            List<string> listaArchivos = new List<string>();
            FtpWebRequest ListarDirectorio = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + directorio);
            ListarDirectorio.Credentials = new NetworkCredential(userName, password);
            ListarDirectorio.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)ListarDirectorio.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            while (!reader.EndOfStream)
            {
                listaArchivos.Add(reader.ReadLine());
            }

            return listaArchivos;
        }

        //Función para descargar archivos
        public static void DescargarArchivo(string ipServidor, string userName, string password, string RutaLocal, string rutaArchivo)
        {
            try
            {
                FtpWebRequest DescargarArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + "/" + rutaArchivo);
                DescargarArchivo.Credentials = new NetworkCredential(userName, password);
                DescargarArchivo.Method = WebRequestMethods.Ftp.DownloadFile;
                using (Stream ftpStream = DescargarArchivo.GetResponse().GetResponseStream())
                try
                {
                    using (Stream fileStream = File.Create(RutaLocal + "\\" + rutaArchivo.Substring(rutaArchivo.IndexOf("/"))))
                    {
                        ftpStream.CopyTo(fileStream);
                    }
                }
                catch
                {
                    using (Stream fileStream = File.Create(RutaLocal + "\\" + rutaArchivo))
                    {
                        ftpStream.CopyTo(fileStream);
                    }
                }

                //FtpRename(userName, password, "ftp://" + ipServidor + "/" + rutaArchivo, "Tractats", rutaArchivo.Substring(rutaArchivo.IndexOf("/")));
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
                reqFTP.RenameTo = ".../" + carpeta_destino + "/" + nombre_archivo;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                reqFTP.GetResponse().Close();
            }
            catch { }

        }
    }
}
