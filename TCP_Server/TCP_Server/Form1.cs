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
        bool sortir = true;
        TcpClient client;
        NetworkStream nwStreamServer;
        TcpListener listener;
        Thread th_Escuchar;

        public frm_server()
        {
            InitializeComponent();
        }

        private void frm_server_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            th_Escuchar = new Thread(EscucharCliente);
            th_Escuchar.Start();

            this.FormClosed += (se, ev) => { sortir = false; };
        }

        private void EscucharCliente()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, Int32.Parse(txtb_port.Text.Trim()));
                listener.Start();
                while (sortir)
                {
                    //ESPERA UN MENSAJE DE ENTRADA
                    if (listener.Pending())
                    {
                        //TRATAR MENSAJE DE ENTRADA
                        client = listener.AcceptTcpClient();
                        byte[] buffer = new byte[client.ReceiveBufferSize];
                        nwStreamServer = client.GetStream();
                        int bytesLength= nwStreamServer.Read(buffer, 0, client.ReceiveBufferSize);
                        string _dataRecived = Encoding.ASCII.GetString(buffer);

                        txtb_datosRecibidos.Text += "\n"+_dataRecived;
                        
                        //DEVOLVER UNA RESPUESTA
                        RespuestaCliente("Respuesta recibida");
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RespuestaCliente(string respuesta)
        {
            try
            {
                byte[] nouBuffer = Encoding.ASCII.GetBytes(respuesta);
                nwStreamServer = client.GetStream();
                nwStreamServer.Write(nouBuffer, 0, nouBuffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region FUNCIONES INUTILES
        //PARA DESCONECTARSE --APARENTEMENTE INUTIL
        //private void btn_desconectar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        client.Close();
        //        listener.Stop();
        //        nwStreamServer.Close();
        //    }
        //    catch
        //    {}
        //}

        private string GetIP()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
        #endregion
    }
}
