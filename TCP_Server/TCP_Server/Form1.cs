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

            this.FormClosed += (se, ev) => { sortir = false; };
        }

        private void EscucharClienteMensaje()
        {
            try
            {
                TcpListener listener1 = new TcpListener(IPAddress.Any, Int32.Parse(txtb_port.Text.Trim()));
                listener1.Start();
                while (sortir)
                {
                    //ESPERA UN MENSAJE DE ENTRADA
                    if (listener1.Pending())
                    {
                        //TRATAR MENSAJE DE ENTRADA
                        client = listener1.AcceptTcpClient();
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
                TcpListener listener2 = new TcpListener(IPAddress.Any, 8889);
                listener2.Start();
                while (sortir)
                {
                    //ESPERA UN MENSAJE DE ENTRADA
                    if (listener2.Pending())
                    {
                        string SaveFileName = string.Empty;
                        SaveFileDialog DialogSave = new SaveFileDialog();
                        DialogSave.Filter = "All files (*.*)|*.*";
                        DialogSave.RestoreDirectory = true;
                        DialogSave.Title = "Where do you want to save the file?";
                        DialogSave.InitialDirectory = @"C:/";
                        if (DialogSave.ShowDialog() == DialogResult.OK)
                            SaveFileName = DialogSave.FileName;
                        if (SaveFileName != string.Empty)
                        {
                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                            while ((RecBytes = nwStreamServer.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                Fs.Write(buffer, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();
                        }
                        nwStreamServer.Close();

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
