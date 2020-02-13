using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIP
{
    public partial class frm_tcpip : Form
    {
        public frm_tcpip()
        {
            InitializeComponent();
        }

        private void btn_escuchar_Click(object sender, EventArgs e)
        {
            try
            {
                //---listen at the specified IP and port no.---
                IPAddress localAdd = IPAddress.Parse(txtb_ip.Text.Trim());
                TcpListener listener = new TcpListener(localAdd, Int32.Parse(txtb_puerto.Text.Trim()));
                listener.Start();

                //---incoming client connected---
                TcpClient client = listener.AcceptTcpClient();

                //---get the incoming data through a network stream---
                NetworkStream streamListener = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = streamListener.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                txtb_DatosRecividos.Text = dataReceived;

                streamListener.Write(buffer, 0, bytesRead);
                client.Close();
                listener.Stop();
            }
            catch
            {
                MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //---data to send to the server---
                string textToSend = DateTime.Now.ToString();

                //---create a TCPClient object at the IP and port no.---
                TcpClient client = new TcpClient(txtb_ip_Sender.Text.Trim(), Int32.Parse(txtb_puerto_sender.Text.Trim()));
                NetworkStream StreamSender = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(txtb_send_data.Text);

                //---send the text---
                StreamSender.Write(bytesToSend, 0, bytesToSend.Length);

                //---read back the text---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = StreamSender.Read(bytesToRead, 0, client.ReceiveBufferSize);
                client.Close();
            }
            catch
            {
                MessageBox.Show("Ha habido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
