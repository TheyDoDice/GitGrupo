using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemWatcherService
{
    public partial class SecureCore : ServiceBase
    {
        string CarpetaDescargas = "C:\\ProvaServei";
        string path = @"C:\\LogFile.txt";

        public SecureCore()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Servicio iniciado a las {0}", DateTime.Now.ToString("HH:mm:ss"));
                }
            }

            watcher.Path = CarpetaDescargas;
            watcher.Filter = "*.edi";
            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Se ha iniciado el System Watcher a las {0}", DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        protected override void OnStop()
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Se ha parado el System Watcher a las {0}", DateTime.Now.ToString("HH:mm:ss"));
            }
            watcher.EnableRaisingEvents = false;
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {

            string NombreArchivo = e.FullPath.Split('\\').Last();
            try
            {
                MoveFile(e.FullPath, CarpetaDescargas + "\\Tractats\\" + NombreArchivo);
            }
            catch
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Error en la función de mover archivos");
                }
            }
                
        }

        private async void MoveFile(string sourceFile, string destinationFile)
        {
            try
            {
                using (FileStream sourceStream = File.Open(sourceFile, FileMode.Open))
                {
                    using (FileStream destinationStream = File.Create(destinationFile))
                    {
                        await sourceStream.CopyToAsync(destinationStream);
                        sourceStream.Close();
                        File.Delete(sourceFile);
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine("Se ha movido el archivo {0} a {1}.", sourceFile, destinationFile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Error al mover el archivo {0} a {1} excepción: {2}.", sourceFile, destinationFile, ex.ToString());
                }
            }
            
        }
    }
}
