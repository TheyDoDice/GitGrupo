using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    public partial class Form1 : Form
    {
        //SERVIDOR Y CLIENTE
        ServerTCP serverTcp = new ServerTCP();
        ClientTCP clientTcp = new ClientTCP();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SERVIDOR EN MARCHA
            serverTcp.iniciarServer(txt_chat, int.Parse(txt_ServerChatPort.Text), int.Parse(txt_ServerDataPort.Text), txt_ServerDataName.Text, lbl_estado);
            this.FormClosed += (se, ev) => { serverTcp.apagarServer(); };
            btn_reiniciarServer.Enabled = false;
        }

        private void btn_ClientConect_Click(object sender, EventArgs e)
        {
            clientTcp.setClient(txt_ClientIp.Text, int.Parse(txt_ClientPort.Text));
        }

        private void btn_sendChat_Click(object sender, EventArgs e)
        {
            clientTcp.enviarChat(txt_ClientChatMessage.Text, lbl_estado);
            MessageBox.Show(IPAddress.Any.ToString());

            if (txt_ClientIp.Text != "127.0.0.1")
            {
                txt_chat.Text += "\n" + txt_ClientChatMessage.Text;
            }
        }

        private void btn_sendData_Click(object sender, EventArgs e)
        {
            clientTcp.enviarData("PACSSOL.txt", lbl_estado);
        }
    }
}
