using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
namespace WindowsFormsApp1
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void bttn_enviarDades_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_estado.Text = "Enviando";

                TcpClient client = new TcpClient(tbx_ip.Text.Trim(), Int32.Parse(tbx_port.Text.Trim()));
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
    }
}
