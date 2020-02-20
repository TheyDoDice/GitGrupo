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
                TcpClient client = new TcpClient(tbx_ip.Text.Trim(), Int32.Parse(tbx_port.Text.Trim()));
                Byte[] dades = Encoding.ASCII.GetBytes(tbx_Message.Text);

                NetworkStream ns = client.GetStream();

                //Enviar dades al servidor
                ns.Write(dades, 0, dades.Length);

                //Rebre Resposta servidor
                byte[] dadaResposta = new Byte[client.ReceiveBufferSize];
                String resposta = textBox2.Text;
                Int32 bytes = ns.Read(dadaResposta, 0, dadaResposta.Length);
                resposta = Encoding.ASCII.GetString(dadaResposta);

                MessageBox.Show(resposta, "Resposta Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
