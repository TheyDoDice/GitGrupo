using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace RecepcióComandes
{
    public partial class RecepcióDeComandes : Form
    {
        public RecepcióDeComandes()
        {
            InitializeComponent();

            #region BARRA SUPERIOR



            ptb_close.Image = TakeImg("dark", "close");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Color.LightCoral;
            ptb_close.Click += (se, ev) => this.Close();

            ptb_minimize.Image = TakeImg("dark", "minimize");
            ptb_minimize.MouseLeave += (se, ev) => ptb_minimize.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            ptb_minimize.MouseEnter += (se, ev) => ptb_minimize.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");
            ptb_minimize.Click += (se, ev) => this.WindowState = FormWindowState.Minimized;

            ptb_maximize.Image = TakeImg("dark", "maximize_1");
            ptb_maximize.MouseLeave += (se, ev) => ptb_maximize.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            ptb_maximize.MouseEnter += (se, ev) => ptb_maximize.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");
            ptb_maximize.Click += (se, ev) => this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            ptb_maximize.Click += (se, ev) => ptb_maximize.Image = this.WindowState != FormWindowState.Maximized ? TakeImg("dark", "maximize_2") : TakeImg("dark", "maximize_1");

            barraSuperior.MouseDown += MovePanel;
            barraSuperior.MouseDown += (se, ev) => ptb_maximize.Image = this.WindowState != FormWindowState.Maximized ? TakeImg("dark", "maximize_2") : TakeImg("dark", "maximize_1");

            #endregion
        
            #region FOCUS TEXTBOX
            txtb_Servidor.Leave += (se, ev) => txtb_Servidor.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_Servidor.Enter += (se, ev) => txtb_Servidor.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_user.Leave += (se, ev) => txtb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_user.Enter += (se, ev) => txtb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_contraseña.Leave += (se, ev) => txtb_contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_contraseña.Enter += (se, ev) => txtb_contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_puerto.Leave += (se, ev) => txtb_puerto.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_puerto.Enter += (se, ev) => txtb_puerto.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            #endregion
        }

        #region MOVEPANEL
        private const int ButtonDown = 0xA1;
        private const int HtCaption = 0x2;
        [DllImport("User32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void MovePanel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, ButtonDown, HtCaption, 0);
            }
        }

        #endregion

        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }

        //Ruta on es generará el XML amb les credencials.
        private static string RutaArxiuXML = Application.StartupPath + "\\credenciales.xml";
        private static string downloadFolder = Application.StartupPath + "\\Descargas";

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            string serv, user, pass, port;

            //Llegir dades Textbox
            pass = txtb_contraseña.Text;
            serv = txtb_Servidor.Text;
            user = txtb_user.Text;

            //Si el textbox puerto está en blanc ficar el port predeterminat
            if (string.IsNullOrEmpty(txtb_puerto.Text.Trim()))
            {
                port = "21";
            }
            else
            {
                port = txtb_puerto.Text;
            }

            //Encriptar valors i escriure Dades Arxiu .txt
            XmlWriter writer = XmlWriter.Create(RutaArxiuXML);
            writer.WriteStartElement("Credencials");
            writer.WriteElementString("IP",serv.Trim());
            writer.WriteElementString("Port", port.Trim());
            writer.WriteElementString("User", user.Trim());
            writer.WriteElementString("Password", pass.Trim());
            writer.WriteElementString("CarpetaBaixada", downloadFolder.Trim());
            writer.WriteEndElement();
            writer.Flush();

            /*
            DADES FTP:
            -IP: 172.17.6.0
            -User: g02
            -Pass: 12345aA
            -Port: 22
             * */

        }

        private void RecepcióDeComandes_Load(object sender, EventArgs e)
        {
            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\carpeta.png"));
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\archivo.png"));
            VisorArchivos.ImageList = myImageList;

            txtb_ruta.Text = downloadFolder;
        }

        private void btn_descargar_Click(object sender, EventArgs e)
        {
        }

        //Ruta on es guardarán les descarregues
        private void txtb_ruta_MouseClick(object sender, MouseEventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtb_ruta.Text = fbd.SelectedPath;
            }
        }
    }
}
