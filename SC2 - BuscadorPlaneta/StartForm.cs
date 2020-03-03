using BuscadorPlaneta;
using PacsLibrary;
using PacsLibrary.Model;
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

namespace FormsIniciales
{
    public partial class StartForm : Form
    {
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

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            Images img = new Images();
            this.CenterToScreen();
            #region BARRA SUPERIOR

            barraSuperior.MouseDown += MovePanel;

            ptb_close.Image = img.TakeImg("dark", "close");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = Colors.c_panels;
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Color.LightCoral;
            ptb_close.Click += (se, ev) => this.Close();

            ptb_minimize.Image = img.TakeImg("dark", "minimize");
            ptb_minimize.MouseLeave += (se, ev) => ptb_minimize.BackColor = Colors.c_panels;
            ptb_minimize.MouseEnter += (se, ev) => ptb_minimize.BackColor = Colors.c_hoverControls;
            ptb_minimize.Click += (se, ev) => this.WindowState = FormWindowState.Minimized;

            #endregion

            ptb_decoration.Image = img.TakeImg("dark", "logo");

            btn_enterPlanet.Leave += (se, ev) => btn_enterPlanet.BackColor = Colors.c_panels;
            btn_enterSpaceship.Enter += (se, ev) => btn_enterSpaceship.BackColor = Colors.c_subPanels;
        }

        private void btn_enterPlanet_Click(object sender, EventArgs e)
        {
            EnterPlanet enterPlanet = new EnterPlanet();
            enterPlanet.FormClosed += (se, ev) => this.Close();
            this.Hide();
            enterPlanet.Show();
        }

        private void btn_enterSpaceship_Click(object sender, EventArgs e)
        {
            EnterSpaceship enterSpaceship= new EnterSpaceship();
            enterSpaceship.FormClosed += (se, ev) => this.Close();
            this.Hide();
            enterSpaceship.Show();
        }
    }
}
