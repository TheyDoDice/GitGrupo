using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class frm_server : Form
    {
        public frm_server()
        {
            InitializeComponent();
        }

        string dataReceived = null;
        bool sortir = true;

        TcpClient client;
        NetworkStream nwStreamServer;
        TcpListener listener;
        Thread th_Escuchar;

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            th_Escuchar = new Thread(() => { dataReceived = EscucharCliente(); });
            th_Escuchar.Start();
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                client.Close();
                listener.Stop();
                nwStreamServer.Close();
            }
            catch
            {

            }
        }

        private void btn_respuesta_Click(object sender, EventArgs e)
        {
            RespuestaCliente("Respuesta del servidor: " + GetIP());
        }

        private string EscucharCliente()
        {
            string _dataRecived = "";
            try
            {
                listener = new TcpListener(IPAddress.Any, Int32.Parse(txtb_port.Text.Trim()));
                listener.Start();
                while (sortir)
                {
                    if (listener.Pending())
                    {
                        client = listener.AcceptTcpClient();

                        nwStreamServer = client.GetStream();
                        byte[] buffer = new byte[client.ReceiveBufferSize];

                        int bytesRead = nwStreamServer.Read(buffer, 0, client.ReceiveBufferSize);

                        _dataRecived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        txtb_datosRecibidos.Text = _dataRecived;
                        //sortir = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _dataRecived;
        }


        private bool RespuestaCliente(string respuesta)
        {
            try
            {
                byte[] nouBuffer = Encoding.ASCII.GetBytes(respuesta);
                nwStreamServer = client.GetStream();
                nwStreamServer.Write(nouBuffer, 0, nouBuffer.Length);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string GetIP()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
    }
}
