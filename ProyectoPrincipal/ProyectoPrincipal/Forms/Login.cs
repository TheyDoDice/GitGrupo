using ProyectoPrincipal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encriptar;

namespace ProyectoPrincipal.Forms
{
    public partial class Login : Form
    {
        private string username = "User";

        private bool primerClickUser = true;
        private bool primerClickPass = true;

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

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            #region BARRA SUPERIOR

            barraSuperior.MouseDown += MovePanel;

            ptb_close.Image = TakeImg("dark", "close");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = Colors.c_panels;
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Color.LightCoral;
            ptb_close.Click += (se, ev) => this.Close();

            ptb_minimize.Image = TakeImg("dark", "minimize");
            ptb_minimize.MouseLeave += (se, ev) => ptb_minimize.BackColor = Colors.c_panels;
            ptb_minimize.MouseEnter += (se, ev) => ptb_minimize.BackColor = Colors.c_hoverControls;
            ptb_minimize.Click += (se, ev) => this.WindowState = FormWindowState.Minimized;

            #endregion

            ptb_decoration.Image = TakeImg("dark", "logo");

            btn_login.MouseLeave += (se, ev) => btn_login.BackColor = Colors.c_panels;
            btn_login.MouseEnter += (se, ev) => btn_login.BackColor = Colors.c_subPanels;

            txt_user.MouseLeave += (se, ev) => txt_user.BackColor = Colors.c_panels;
            txt_user.MouseEnter += (se, ev) => txt_user.BackColor = Colors.c_hoverControls;
            txt_user.Click += (se, ev) => txt_user.Text = primerClickUser ? "" : txt_user.Text;
            txt_user.Click += (se, ev) => primerClickUser = false;
            txt_password.MouseLeave += (se, ev) => txt_password.BackColor = Colors.c_panels;
            txt_password.MouseEnter += (se, ev) => txt_password.BackColor = Colors.c_hoverControls;
            txt_password.Click += (se, ev) => txt_password.Text = primerClickPass ? "" : txt_password.Text;
            txt_password.Click += (se, ev) => primerClickPass = false;
            txt_password.Click += (se, ev) => txt_password.PasswordChar = '■';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (correctUser(txt_user.Text, txt_password.Text))
            {
                Splash splash = new Splash(username);
                splash.FormClosed += (se, ev) => this.Close();
                this.Hide();
                splash.Show();
            }
        }

        private bool correctUser(string user, string password)
        {
            BBDD.Dades basedades = new BBDD.SQL();
            DataSet dataSet = basedades.userCredentials(user);
            try
            {
                byte[] passwordBase = Convert.FromBase64String(dataSet.Tables[0].Rows[0]["Password"].ToString());
                byte[] saltBase = Convert.FromBase64String(dataSet.Tables[0].Rows[0]["Salt"].ToString());

                Hash encript = new Hash();

                return encript.VerifyPassword(password, saltBase, passwordBase);
            }
            catch
            {
                return false;
            }
        }
        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }
    }
}
