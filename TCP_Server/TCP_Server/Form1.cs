using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class frm_server : Form
    {
        int RecBytes;
        byte[] buffer;
        bool sortir = true;

        NetworkStream nwStreamServer;
        Thread th_Escuchar1, th_Escuchar2;
        TcpClient client;

        public frm_server()
        {
            InitializeComponent();
        }

        private void frm_server_Load(object sender, EventArgs e)
        {
            th_Escuchar1 = new Thread(EscucharClienteMensaje);
            th_Escuchar1.Start();

            th_Escuchar2 = new Thread(EscucharClienteArchivo);
            th_Escuchar2.Start();

            //this.FormClosed += (se, ev) => { sortir = false; };
        }

        private void EscucharClienteMensaje()
        {
            try
            {
                TcpListener listenerMsg = new TcpListener(IPAddress.Any, Int32.Parse(txtb_port.Text.Trim()));
                listenerMsg.Start();
                while (sortir)
                {
                    //ESPERA UN MENSAJE DE ENTRADA
                    if (listenerMsg.Pending())
                    {
                        //TRATAR MENSAJE DE ENTRADA
                        client = listenerMsg.AcceptTcpClient();
                        buffer = new byte[client.ReceiveBufferSize];
                        nwStreamServer = client.GetStream();
                        int bytesLength= nwStreamServer.Read(buffer, 0, client.ReceiveBufferSize);
                        string _dataRecived = Encoding.ASCII.GetString(buffer);

                        txtb_datosRecibidos.Invoke((MethodInvoker) delegate
                        {
                            txtb_datosRecibidos.Text += "\n" + _dataRecived;
                        });
                        
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

        private void EscucharClienteArchivo()
        {
            try
            {
                TcpListener listenerData = new TcpListener(IPAddress.Any, int.Parse(txtb_portData.Text));
                listenerData.Start();
                while (sortir)
                {
                    //ESPERA UN ARCHIVO DE ENTRADA
                    if (listenerData.Pending())
                    {
                        client = listenerData.AcceptTcpClient();
                        nwStreamServer = client.GetStream();
                        buffer = new byte[client.ReceiveBufferSize];

                        string SaveFileName = @"C:\Users\admin\Desktop\"+ txtb_portExtensio.Text;

                        int totalrecbytes = 0;
                        FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                        while ((RecBytes = nwStreamServer.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            Fs.Write(buffer, 0, RecBytes);
                            totalrecbytes += RecBytes;
                        }
                        //int n = 0;
                        //do
                        //{
                        //    n++;
                        //    RecBytes = nwStreamServer.Read(buffer, 0, buffer.Length);
                        //    Fs.Write(buffer, 0, RecBytes);
                        //}
                        //while (nwStreamServer.DataAvailable);

                        Fs.Close();

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
                nwStreamServer.Write(nouBuffer, 0, nouBuffer.Length);
                nwStreamServer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
