﻿using ProyectoPrincipal.Model;
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
using CC_Library;

namespace ProyectoPrincipal.Forms
{
    public partial class Menu : Form
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

        private string user;
        private int userRank;
        private DataSet menuOptions;

        public Menu(string user, int userRank, DataSet menuOptions)
        {
            this.user = user;
            this.userRank = userRank;
            this.menuOptions = menuOptions;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            #region BARRA SUPERIOR

            ptb_logo.Image = TakeImg("dark", "logo");

            ptb_close.Image = TakeImg("dark", "close");
            ptb_close.MouseLeave += (se, ev) => ptb_close.BackColor = Colors.c_panels;
            ptb_close.MouseEnter += (se, ev) => ptb_close.BackColor = Color.LightCoral;
            ptb_close.Click += (se, ev) => this.Close();

            ptb_minimize.Image = TakeImg("dark", "minimize");
            ptb_minimize.MouseLeave += (se, ev) => ptb_minimize.BackColor = Colors.c_panels;
            ptb_minimize.MouseEnter += (se, ev) => ptb_minimize.BackColor = Colors.c_hoverControls;
            ptb_minimize.Click += (se, ev) => this.WindowState = FormWindowState.Minimized;

            ptb_maximize.Image = TakeImg("dark", "maximize_1");
            ptb_maximize.MouseLeave += (se, ev) => ptb_maximize.BackColor = Colors.c_panels;
            ptb_maximize.MouseEnter += (se, ev) => ptb_maximize.BackColor = Colors.c_hoverControls;
            ptb_maximize.Click += (se, ev) => this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            ptb_maximize.Click += (se, ev) => ptb_maximize.Image = this.WindowState != FormWindowState.Maximized ? TakeImg("dark", "maximize_2") : TakeImg("dark", "maximize_1");

            barraSuperior.MouseDown += MovePanel;
            barraSuperior.MouseDown += (se, ev) => ptb_maximize.Image = this.WindowState != FormWindowState.Maximized ? TakeImg("dark", "maximize_2") : TakeImg("dark", "maximize_1");

            #endregion

            ptb_user.Image = TakeImg("dark", "user");
            ptb_user.MouseEnter += (se, ev) => lbl_user.ForeColor = Color.DimGray;
            ptb_user.MouseLeave += (se, ev) => lbl_user.ForeColor = Color.White;
            ptb_user.MouseLeave += (se, ev) => ptb_user.Image = TakeImg("dark", "user");
            ptb_user.MouseEnter += (se, ev) => ptb_user.Image = TakeImg("select", "user");
            ptb_close.Click     += (se, ev) => { Restart(); };

            lbl_user.Text += user;
            lbl_user.MouseEnter += (se, ev) => lbl_user.ForeColor = Color.DimGray;
            lbl_user.MouseLeave += (se, ev) => lbl_user.ForeColor = Color.White;
            lbl_user.MouseEnter += (se, ev) => ptb_user.Image = TakeImg("select", "user");
            lbl_user.MouseLeave += (se, ev) => ptb_user.Image = TakeImg("dark", "user");
            lbl_user.Click      += (se, ev) => { Restart(); };


            foreach (DataRow item in menuOptions.Tables[0].Rows)
            {
                SWMenuItem OpcioMenu = new SWMenuItem();

                OpcioMenu.Name      = item[0].ToString();
                OpcioMenu.NomClasse = item["NomClase"].ToString();
                OpcioMenu.NomDLL    = item["NomDLL"].ToString();
                OpcioMenu.NameSpace = item["NameSpace"].ToString();
                OpcioMenu.PanelForm = item["NomPanel"].ToString();
                OpcioMenu.Dock      = DockStyle.Bottom;

                barraMenu.Controls.Add(OpcioMenu);
                OpcioMenu.Show();
            }

        }

        private void Restart()
        {
            this.Hide();
            Application.Restart();
            Environment.Exit(0);
        }

        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }
        
    }
}
