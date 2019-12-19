using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;
using System.Xml.Linq;
namespace ConsolaGestionFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;
            XDocument Credenciales = XDocument.Load("C:\\Users\\admin\\Desktop\\GitGrupo\\Proyectos\\ConfigConsola.xml");

            Console.Title = "FTP Files Downloader";
            foreach (XElement node in Credenciales.Descendants("ConfigConsola"))
            {
               Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), node.Element("ColorTexto").Value);
               Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), node.Element("ColorFondo").Value);
            }

            Console.WriteLine("Escribe 'Comandos' para ver los comandos disponibles");
            comando = Console.ReadLine();
            while (true)
            {
                if (String.Equals(comando, "Comandos", StringComparison.OrdinalIgnoreCase))
                {
                    MostrarComandos();
                }
                else if (String.Equals(comando, "MostrarDatosServidor", StringComparison.OrdinalIgnoreCase))
                {
                    MostrarDatosServer(args);
                }
                else if(String.Equals(comando, "ComprobarArchivos", StringComparison.OrdinalIgnoreCase))
                {
                    DescargarArchivos(args);
                }
                else if (String.Equals(comando, "LimpiarPantalla", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                }
                else if (String.Equals(comando, "PingAlServidor -detalles", StringComparison.OrdinalIgnoreCase))
                {
                    ping(args[0], 1, 7000);
                }
                else if (String.Equals(comando, "PingAlServidor", StringComparison.OrdinalIgnoreCase))
                {
                    ping(args[0], 0, 7000);
                }
                comando = Console.ReadLine();
            }
        }

        private static void ping (string ip, int detalles, int tiempo_espera)
        {
            try
            {
                Ping pinger = new Ping();
                PingOptions options = new PingOptions(128,true);

                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = tiempo_espera;

                PingReply reply = pinger.Send(ip, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    if (detalles == 1)
                    {
                        Console.WriteLine("Dirección: {0}", reply.Address.ToString());
                        Console.WriteLine("Viaje ida y vuelta: {0}", reply.RoundtripTime);
                        Console.WriteLine("Tiempo de vida: {0}", reply.Options.Ttl);
                        Console.WriteLine("No fragmentar: {0}", reply.Options.DontFragment);
                        Console.WriteLine("Tamaño del búfer: {0}", reply.Buffer.Length);
                    }
                    else
                    {
                        Console.WriteLine("Ping a {0} correcto", ip);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ping a {0} fallido", ip);
            }

            Console.WriteLine("");
        }

        private static void MostrarComandos()
        {
            Console.WriteLine("'MostrarDatosServidor' para ver los detalles del servidor.");
            Console.WriteLine("'ComprobarArchivos' para comprobar si hay archivos nuevos en el servidor.");
            Console.WriteLine("'PingAlServidor -detalles' para hacer un ping al servidor y ver los detalles");
            Console.WriteLine("'PingAlServidor' para hacer un ping al servidor sin ver los detalles");
            Console.WriteLine("'LimpiarPantalla' para limpiar la pantalla.");
            Console.WriteLine("");
        }

        //Datos conexión
        private static void MostrarDatosServer(string[] arguments)
        {
            Console.WriteLine("Datos del servidor:\n");
            Console.WriteLine("Servidor: {0}\nUsuario: {1}\nContraseña: {2}\nCarpeta Descargas: {3}\nRuta Descargas: {4}", arguments[0], arguments[1], OcultarContraseña(arguments[2], '*'), arguments[3], arguments[4]);
            Console.WriteLine("");
        }

        //Función para descargar archivos
        private static void DescargarArchivos(string[] arguments)
        {
            List<string> FileList = new List<string>();
            try
            {
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
            Console.WriteLine("");
        }

        //Cambiar los caracteres de una contraseña
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
            FtpWebRequest ListarDirectorio = (FtpWebRequest)WebRequest.Create("ftp://" + ipServidor + directorio);
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
                string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                if (permissions[0] == 'd')
                {
                    Console.WriteLine($"Se ha encontrado el directorio: {name}");
                    ListarArchivos(ipServidor,userName,password, "/" + name);
                }
                else
                {
                    Console.WriteLine($"Se ha encontrado el archivo: {name}");
                    listaArchivos.Add(name);
                }
            }
            Console.WriteLine("");
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
