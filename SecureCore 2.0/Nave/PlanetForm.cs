using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BibliotecaPACS;

namespace Nave
{
    public partial class frm_nave : Form
    {
        //SERVIDOR Y CLIENTE
        ServerTCP serverTcp = new ServerTCP();
        ClientTCP clientTcp = new ClientTCP();

        int portChat = 8888;
        int portData = 8889;
        string ip = "172.17.22.48";

        string lastMessage = "";

        Dictionary<string, string> Codificacio = new Dictionary<string, string>();
        string FilePathLLetres = Application.StartupPath + "\\Planet\\FicherosTextos";
        string FilePathPACS = Application.StartupPath + "\\Planet\\FicherosPACS";
        const int MidaFitxersPACS = 500000;
        const int NumFitxers = 3;


        public frm_nave()
        {
            InitializeComponent();
        }

        private void frm_nave_Load(object sender, EventArgs e)
        {
            //INICIAR SERVIDOR   
            serverTcp.iniciarServer(txtb_consola, portChat, portData, "pacsSend.txt", lbl_state);
            this.FormClosed += (se, ev) => { serverTcp.apagarServer(); };

            #region Botones 
            btn_entregar_datos.Enabled = false;
            btn_entregar_datos.Image = TakeImg("buttonv2_disabled");

            btn_preparar_datos.Enabled = false;
            btn_preparar_datos.Image = TakeImg("buttonv2_disabled");

            btn_verificar.MouseEnter += (send, ev) => btn_verificar.Image = TakeImg("buttonv2_hover");
            btn_verificar.MouseLeave += (send, ev) => btn_verificar.Image = TakeImg("buttonv2");

            btn_entregar_datos.MouseEnter += (send, ev) => btn_entregar_datos.Image = TakeImg("buttonv2_hover");
            btn_entregar_datos.MouseLeave += (send, ev) => btn_entregar_datos.Image = TakeImg("buttonv2");

            btn_preparar_datos.MouseEnter += (send, ev) => btn_preparar_datos.Image = TakeImg("buttonv2_hover");
            btn_preparar_datos.MouseLeave += (send, ev) => btn_preparar_datos.Image = TakeImg("buttonv2");

            #endregion
            #region consola autoscroll
            txtb_consola.TextChanged += (se, ev) =>
            {
                if (txtb_consola.Visible)
                {
                    txtb_consola.SelectionStart = txtb_consola.TextLength;
                    txtb_consola.ScrollToCaret();
                }
            };

            txtb_consola.TextChanged += (se, ev) =>
            {
                try
                {
                    lastMessage = txtb_consola.Text.Split('➖').LastOrDefault().Trim();
                }
                catch
                {
                }
            };
            #endregion
        }

        private void btn_EnviarInput_Click(object sender, EventArgs e)
        {
            //INICIAR CLIENTE
            clientTcp.setClient(ip, portChat);
            clientTcp.enviarChat(txt_Input.Text, lbl_state);

            txtb_consola.Text += Environment.NewLine + "[Mensaje Planeta] ➖ " + txt_Input.Text;
            txt_Input.Text = "";
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lastMessage);

            switch (lastMessage)
            {
                case "quiero entrar":

                    MessageBox.Show("ahora te dejo pasar");

                    break;
                default:
                    break;
            }
        }

        private Image TakeImg(string name)
        {
            string dir = Path.GetDirectoryName(Application.StartupPath + "\\Img\\NewSecureCore\\");
            return Image.FromFile(dir + "\\" + name + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INICIAR CLIENTE
            clientTcp.setClient(ip, portData);
            clientTcp.enviarData("pacsEnviar.txt", lbl_state);
        }

        //PREPARAR PACS
        //FitxersPACS pacs = new FitxersPACS();

        //txtb_consola.Text = Environment.NewLine + "Creando archivos PACS...";

        //    Thread GenerarPacs = new Thread(() => {
        //        try
        //        {
        //            Codificacio = pacs.ObtenirCodificacio(999);
        //            Stopwatch Cronometro = Stopwatch.StartNew();
        //            CrearCarpetas();

        //            pacs.GenerarFitxerPacs(MidaFitxersPACS, Codificacio, FilePathPACS, FilePathLLetres, NumFitxers);


        //            btn_entregar_datos.Invoke((MethodInvoker)delegate
        //            {
        //                btn_entregar_datos.Enabled = true;
        //                btn_entregar_datos.Image = TakeImg("buttonv2");
        //            });
        //            Cronometro.Stop();

        //            txtb_consola.Invoke((MethodInvoker)delegate
        //            {
        //                txtb_consola.Text += Environment.NewLine + "Archivos creados correctamente";
        //                txtb_consola.Text += Environment.NewLine + "el proceso ha tardado: " + Cronometro.ElapsedMilliseconds + "ms";
        //            });
        //        }
        //        catch (Exception ex)
        //        {
        //            txtb_consola.Invoke((MethodInvoker)delegate
        //            {
        //                txtb_consola.Text += Environment.NewLine + ex.ToString();
        //            });
        //        }
        //    });

        //GenerarPacs.Start();

        //private void CrearCarpetas()
        //{
        //    if (!Directory.Exists(FilePathLLetres))
        //    {
        //        Directory.CreateDirectory(FilePathLLetres);
        //    }
        //    if (!Directory.Exists(FilePathPACS))
        //    {
        //        Directory.CreateDirectory(FilePathPACS);
        //    }
        //}

    }
}
