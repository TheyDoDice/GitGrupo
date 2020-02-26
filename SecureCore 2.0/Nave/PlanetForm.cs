using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Nave
{
    public partial class frm_nave : Form
    {
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
            #endregion
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            btn_preparar_datos.Enabled = true;
            btn_preparar_datos.Image = TakeImg("buttonv2");
        }

        private void CrearCarpetas()
        {
            if (!Directory.Exists(FilePathLLetres))
            {
                Directory.CreateDirectory(FilePathLLetres);
            }
            if (!Directory.Exists(FilePathPACS))
            {
                Directory.CreateDirectory(FilePathPACS);
            }
        }

        private void btn_clearConsole_Click(object sender, EventArgs e)
        {
            txtb_consola.Clear();
        }

        private Image TakeImg(string name)
        {
            string dir = Path.GetDirectoryName(Application.StartupPath + "\\Img\\NewSecureCore\\");
            return Image.FromFile(dir + "\\" + name + ".png");
        }

        private void btn_EnviarInput_Click(object sender, EventArgs e)
        {
            txtb_consola.Text += Environment.NewLine + "- " + txt_Input.Text;
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

    }
}
