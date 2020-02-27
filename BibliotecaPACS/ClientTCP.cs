using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPACS
{
    public class ClientTCP
    {
        //VARIABLES Y CONSTANTES
        private const int BufferSize = 1024;
        TcpClient client = null;

        private int port  = 8888;
        private string ip = "127.0.0.1";

        public void setClient(string ip, int port)
        {
            this.port = port;
            this.ip = ip;
        }

        public void enviarChat(string message, Label labelState)
        {
            try
            {
                labelState.Text = "Sending...";

                client = new TcpClient(ip, port);
                Byte[] dades = Encoding.ASCII.GetBytes(message);

                NetworkStream ns = client.GetStream();

                //Enviar dades al servidor
                ns.Write(dades, 0, dades.Length);

                labelState.Text = "Message Sent";
            }
            catch
            {
                labelState.Text = "Server disconect";
            }
        }
        public void enviarData(string filePath, Label labelState)
        {
            byte[] SendingBuffer = null;
            NetworkStream netstream = null;
            try
            {
                labelState.Text = "Sending...";

                client = new TcpClient(ip, port);
                netstream = client.GetStream();

                FileStream Fs = new FileStream("C:\\Users\\admin\\Desktop\\"+ filePath, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));

                int TotalLength = (int)Fs.Length, CurrentPacketLength;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength -= CurrentPacketLength;
                    }
                    else
                    {
                        CurrentPacketLength = TotalLength;
                    }
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                }

                Fs.Close();
                labelState.Text = "Data Sent";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                labelState.Text = "Servidor no conectat";
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }
    }
}
