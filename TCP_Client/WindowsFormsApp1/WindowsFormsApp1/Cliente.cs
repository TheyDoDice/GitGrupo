using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Cliente : Form
    {
        private const int BufferSize = 1024;
        TcpClient client = null;

        public Cliente()
        {
            InitializeComponent();
        }

        private void bttn_enviarDades_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_estado.Text = "Enviando";

                client = new TcpClient(tbx_ip.Text.Trim(), Int32.Parse(tbx_port.Text.Trim()));
                Byte[] dades = Encoding.ASCII.GetBytes(tbx_Message.Text);

                NetworkStream ns = client.GetStream();

                //Enviar dades al servidor
                ns.Write(dades, 0, dades.Length);

                //Rebre Resposta servidor
                byte[] dadaResposta = new Byte[client.ReceiveBufferSize];
                Int32 bytes = ns.Read(dadaResposta, 0, dadaResposta.Length);
                string resposta = Encoding.ASCII.GetString(dadaResposta);

                lbl_estado.Text = resposta;
            }
            catch
            {
                lbl_estado.Text = "Servidor no conectat";
            }
        }
        private void btn_enviarArchivos_Click(object sender, EventArgs e)
        {
            SendTCP(@"C:\Users\admin\Desktop\PACSSOL.txt");
        }

        public void SendTCP(string filePath)
        {
            byte[] SendingBuffer = null;
            NetworkStream netstream = null;
            try
            {
                client = new TcpClient(tbx_ip.Text.Trim(), Int32.Parse(tbx_port.Text.Trim()));
                netstream = client.GetStream();

                FileStream Fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }
    }
}
