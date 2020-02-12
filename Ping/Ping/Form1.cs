using System;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Ping
{
    public partial class frm_Ping : Form
    {
        public frm_Ping()
        {
            InitializeComponent();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            if(EjecutarPing(txtb_ip.Text.Trim()))
            {
                txtb_consola.Text = "Hay connexión con: " + txtb_ip.Text.Trim();
            }
            else
            {
                txtb_consola.Text = "No hay connexión con: " + txtb_ip.Text.Trim();
            }
        }


        private bool EjecutarPing(string ip)
        {
            bool correcte = false;

            try
            {
                string data = "abcdefghijklllmnopqrstuvwxyzabcd";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;

                PingOptions options = new PingOptions();
                System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
                options.DontFragment = true;

                PingReply reply = pingSender.Send(ip, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                { 
                    correcte = true;
                    pingSender.Dispose();
                }
            }
            catch (Exception ex)
            {
               Debug.WriteLine(ex);
            }

            return correcte;
        }
    }
}
