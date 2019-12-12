using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace ConsolaGestionFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string comando;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "FTP Files Downloader";
            Console.Clear();
            Console.WriteLine("===============================Consola Para Descargar Archivos Del Servidor===============================");
            comando = Console.ReadLine();
            while (true)
            {
                if (comando == "Help")
                {
                    MostrarComandos();
                }
                else if (comando == "ShowDetails")
                {
                    MostrarDatosServer(args);
                }
                else if(comando == "Check")
                {
                    DescargarArchivos(args);
                }
                else if (comando == "cls")
                {
                    Console.Clear();
                }
                comando = Console.ReadLine();
            }
        }

        private static void MostrarComandos()
        {
            Console.WriteLine("Escribe 'Check' para comprovar los archivos.");
            Console.WriteLine("Escribe 'ShowDetails' para ver los detalles del servidor.");
            Console.WriteLine("Escribe 'cls' para limpiar la pantalla.");
        }

        private static void MostrarDatosServer(string[] arguments)
        {

            Console.WriteLine("Datos del servidor:\n");
            Console.WriteLine("Servidor: {0}\nUsuario: {1}\nContraseña: {2}\nCarpeta Descargas: {3}\nRuta Descargas: {4}", arguments[0], arguments[1], OcultarContraseña(arguments[2], '*'), arguments[3], arguments[4]);
        }

        private static void DescargarArchivos(string[] arguments)
        {
            try
            {
                List<string> FileList = new List<string>();
                FileList = ListarArchivos(arguments[0], arguments[1], arguments[2], arguments[4]);
                foreach (string item in FileList)
                {
                    DescargarArchivo(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], item);
                    FtpRename(arguments[1], arguments[2], "ftp://" + arguments[0] + arguments[4] + item, arguments[5], item);
                    Console.Write("Descargando {0} en la carpeta {1}\n", item.Substring(item.IndexOf("/") + 1), arguments[3]);
                }
            }
            catch
            {
                Console.WriteLine("Error, faltan los datos de conexión");
            }
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
                    ListarArchivos(ipServidor,userName,password, "/" + name);
                }
                else
                {
                    Console.WriteLine($"Se ha encontrado el archivo: {name}");
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
                        Console.WriteLine("Se ha descargado el archivo {0}\n", nombreArchivo);
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
                Console.WriteLine("Se ha modificado la ruta del archivo: {0}", nombre_archivo);
            }
            catch { }

        }
    }
}
