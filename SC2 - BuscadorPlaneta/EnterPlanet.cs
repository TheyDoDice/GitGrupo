﻿using BBDD;
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
using Forms;

namespace FormsIniciales
{
    public partial class EnterPlanet : Form
    {
        private static SContext db = new SContext();
        private int idPlanet;
        private int idNave = 0;
        private string ip = "0";

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

        public EnterPlanet()
        {
            InitializeComponent();

        }

        private void EnterPlanet_Load(object sender, EventArgs e)
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

            btn_enter.Leave += (se, ev) => btn_enter.BackColor = Colors.c_panels;

            cmbx_buscarPlaneta.DataSource = db.Planets.ToList();
            cmbx_buscarPlaneta.ValueMember = "DescPlanet";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            PlanetForm planet = new PlanetForm(idPlanet, ip);
            planet.FormClosed += (se, ev) => this.Close();
            this.Hide();
            planet.Show();
        }

        private void cmbx_buscarPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPlanet = db.Planets.ToArray()[cmbx_buscarPlaneta.SelectedIndex].idPlanet;
        }
    }
}
