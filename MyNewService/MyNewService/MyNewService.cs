using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Timers;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;




namespace ProvaServei
{
    public partial class ProvaServei : ServiceBase
    { //Linias agregada
        /*+*/
        /*+*/private static string ruta = "C:\\Users\\admin\\Documents\\test";
        private static string rutaTxt = "C:\\Users\\admin\\Documents\\test\\Nuevo documento de texto.txt";
        FileSystemWatcher VisorProcesar;
        public ProvaServei()
        {

            InitializeComponent();
            

        }

        protected override void OnStart(string[] args)
        {

            //eventLog1.WriteEntry("In OnStart.");

            Timer timer = new Timer
            {
                Interval = 10000 // 60 seconds
            };
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();

            ServiceStatus serviceStatus = new ServiceStatus
            {
                dwCurrentState = ServiceState.SERVICE_START_PENDING,
                dwWaitHint = 100000
            };
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);

            // Update the service state to Running.
            serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);



        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            //eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
            try
            {
                LogMessage();
            }
            catch (Exception)
            {
                using (StreamWriter sw = File.AppendText(rutaTxt))
                {
                    sw.WriteLine("Error a las {0}", DateTime.Now.ToString("HH:mm:ss"));
                }
            }
        }

        private void LogMessage()
        {
            VisorProcesar = new FileSystemWatcher
            {
                Path = ruta
            };
            if (VisorProcesar.Filter != "")
            {
                VisorProcesar.Filter = "*.edi";
                VisorProcesar.Created += OnChanged;


            }
            VisorProcesar.EnableRaisingEvents = true;
        }




        protected override void OnStop()
        {


        }


        public enum ServiceState
        {
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ServiceStatus
        {
            public int dwServiceType;
            public ServiceState dwCurrentState;
            public int dwControlsAccepted;
            public int dwWin32ExitCode;
            public int dwServiceSpecificExitCode;
            public int dwCheckPoint;
            public int dwWaitHint;
        };

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);

        private void OnChanged(object sender, FileSystemEventArgs e)
        {

            try
            {

                string NombreArchivo = e.FullPath.Split('\\').Last();
                MoveFile(e.FullPath, ruta + "\\Tractats\\" + NombreArchivo);

                using (StreamWriter sw = File.AppendText(rutaTxt))
                {
                    sw.WriteLine("Se ha movido el archivo {0} a {1}. A la hora {2}", NombreArchivo, ruta + "\\Tractats\\", DateTime.Now.ToString("HH:mm:ss"));
                }
            }
            catch
            {
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
                    }
                }
            }
            catch
            {
            }

        }
    }
}
