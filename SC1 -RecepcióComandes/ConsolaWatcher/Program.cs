using System.IO;
using System.Linq;
using GenerarOrder;

namespace ConsolaWatcher
{
    class Program
    {
        private static OrderReception comanda = new OrderReception();
        private static string ruta = "C:\\Users\\admin\\Desktop\\test";

        static void Main(string[] args)
        {
            FileSystemWatcher VisorProcesar = new FileSystemWatcher();

            //Comprovar carpeta descargas con el File System Watcher.
            VisorProcesar.Path = ruta;
            VisorProcesar.Filter = "*.edi";
            VisorProcesar.Created += OnChanged;
            VisorProcesar.EnableRaisingEvents = true;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (comanda.GenerarComanda(e.FullPath))
            {
                try
                {
                    string NombreArchivo = e.FullPath.Split('\\').Last();
                    File.Move(e.FullPath, ruta + "\\Tractats\\" + NombreArchivo);
                }
                catch { }
            }
        }
    }
}
