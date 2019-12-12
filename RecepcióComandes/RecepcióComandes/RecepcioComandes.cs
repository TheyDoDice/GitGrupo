﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Xml.Linq;
using System.Drawing.Printing;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using GenerarOrder;
using System.Threading;

namespace RecepcióComandes
{
    public partial class RecepcióDeComandes : Form
    {
        //Imports Consola
        [DllImport("User32.dll")] static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("User32.dll")] static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("User32.dll")] static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        //ORDENAR VARIABLES
        private static string RutaArchivoXML = Application.StartupPath + "\\credenciales.xml";
        private static string CarpetaDescargas = Application.StartupPath + "\\Descargas";
        private XDocument Credenciales = XDocument.Load(RutaArchivoXML);
        private FolderBrowserDialog SelectorCarpetas = new FolderBrowserDialog();
        private OpenFileDialog ExploradorArchivos = new OpenFileDialog();
        FileSystemWatcher VisorProcesar = new FileSystemWatcher();
        private Process Consola = new Process();
        IntPtr App_Consola;
        private Uri CadenaConnexionFTP;


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

            txtb_Usuario.Leave += (se, ev) => txtb_Usuario.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_Usuario.Enter += (se, ev) => txtb_Usuario.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_Contraseña.Leave += (se, ev) => txtb_Contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_Contraseña.Enter += (se, ev) => txtb_Contraseña.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_Puerto.Leave += (se, ev) => txtb_Puerto.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_Puerto.Enter += (se, ev) => txtb_Puerto.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            txtb_RutaCarpetaDescargas.Leave += (se, ev) => txtb_RutaCarpetaDescargas.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            txtb_RutaCarpetaDescargas.Enter += (se, ev) => txtb_RutaCarpetaDescargas.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

            cbx_Impresora.Leave += (se, ev) => cbx_Impresora.BackColor = System.Drawing.ColorTranslator.FromHtml("#393939");
            cbx_Impresora.Enter += (se, ev) => cbx_Impresora.BackColor = System.Drawing.ColorTranslator.FromHtml("#535353");

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
        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }
        #endregion


        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void RecepcióDeComandes_Load(object sender, EventArgs e)
        {

            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\carpeta.png"));
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\archivo.png"));
            VisorArchivos.ImageList = myImageList;

            cbx_Impresora.DataSource = PrinterSettings.InstalledPrinters.Cast<string>().ToList();

            foreach (XElement node in Credenciales.Descendants("Credencials"))
            {
                txtb_Servidor.Text = node.Element("IP").Value;
                txtb_Puerto.Text = node.Element("Port").Value;
                txtb_Usuario.Text = node.Element("User").Value;
                txtb_Contraseña.Text = node.Element("Password").Value;
                txtb_RutaCarpetaDescargas.Text = node.Element("CarpetaBaixada").Value;
                cbx_Impresora.Text = node.Element("Impressora").Value;
            }

            CadenaConnexionFTP = new Uri("ftp://" + txtb_Servidor.Text + "/");

            InicializarMenuContextual();

            ActualizarArbol("/");

            //Comprovar carpeta descargas con el File System Watcher.
            VisorProcesar.Path = txtb_RutaCarpetaDescargas.Text;
            VisorProcesar.Filter = "*.edi";
            VisorProcesar.Created += OnChanged;
            VisorProcesar.EnableRaisingEvents = true;

            IniciarConsola();
        }

        OrderReception comanda = new OrderReception();
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (comanda.GenerarComanda(e.FullPath))
            {
                try
                {
                    string NombreArchivo = e.FullPath.Split('\\').Last();
                    File.Move(e.FullPath, CarpetaDescargas + "\\Tractats\\" + NombreArchivo);
                }
                catch { }
            }
        }

        private void InicializarMenuContextual()
        {
            ToolStripMenuItem Actualizar = new ToolStripMenuItem("Actualizar");
            ToolStripMenuItem CrearCarpeta = new ToolStripMenuItem("Crear carpeta");
            ToolStripMenuItem SubirArchivo = new ToolStripMenuItem("Subir archivo");
            ToolStripMenuItem Borrar = new ToolStripMenuItem("Borrar");

            ContextMenuStrip docMenu = new ContextMenuStrip();
            docMenu.Items.AddRange(
                new ToolStripMenuItem[]{
                    Actualizar,
                    CrearCarpeta,
                    SubirArchivo,
                    Borrar,
                }
            );

            string ipServidor = txtb_Servidor.Text.Trim();
            string userName = txtb_Usuario.Text.Trim();
            string password = txtb_Contraseña.Text.Trim();

            Actualizar.Click += (se, ev) => ActualizarArbol("/");
            CrearCarpeta.Click += (se, ev) => {
                gestionServidorFTP.CrearCarpetaFTP(ipServidor, userName, password, VisorArchivos);
                ActualizarArbol("/");
            };
            SubirArchivo.Click += (se, ev) => {
                gestionServidorFTP.AbrirExploradorSubirArchivos(ExploradorArchivos, ipServidor, userName, password, VisorArchivos);
                ActualizarArbol("/");
            };
            Borrar.Click += (se, ev) => {
                gestionServidorFTP.BorrarDirArchivo("ftp://" + ipServidor + gestionServidorFTP.GetCurrentNodeName(VisorArchivos) + "/", ipServidor, userName, password, VisorArchivos);
                ActualizarArbol("/");
            };

            VisorArchivos.MouseDown += (se, ev) => VisorArchivos.SelectedNode = VisorArchivos.GetNodeAt(ev.X, ev.Y);

            VisorArchivos.ContextMenuStrip = docMenu;
        }

        //ACTUALIZAR ARBOL
        private void ActualizarArbol(string NombrePrimerNodo)
        {
            CrearTreeNode ctn = new CrearTreeNode(txtb_Usuario.Text.Trim(), txtb_Contraseña.Text.Trim());

            int itemsAntiguos = VisorArchivos.GetNodeCount(true);

            VisorArchivos.BeginUpdate();
            VisorArchivos.Nodes.Clear();
            VisorArchivos.Nodes.Add(ctn.CreateDirectoryNode(CadenaConnexionFTP.ToString(), NombrePrimerNodo));

            int itemsNuevos = VisorArchivos.GetNodeCount(true);

            VisorArchivos.EndUpdate();
            VisorArchivos.ExpandAll();
        }

        //BOTON GUARDAR CREDENCIALES EN EL XML
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //DADES FTP:  -IP: 172.17.6.0     -User: g02      -Pass: 12345aA      -Port: 22

            string serv, user, pass;
            int port = 21;

            pass = txtb_Contraseña.Text.Trim();
            serv = txtb_Servidor.Text.Trim();
            user = txtb_Usuario.Text.Trim();

            if (!string.IsNullOrEmpty(txtb_Puerto.Text.Trim()))
            {
                port = int.Parse(txtb_Puerto.Text);
            }

            foreach (XElement node in Credenciales.Descendants("Credencials"))
            {
                node.SetElementValue("IP", serv);
                node.SetElementValue("Port", port);
                node.SetElementValue("User", user);
                node.SetElementValue("Password", pass);
                node.SetElementValue("CarpetaBaixada", CarpetaDescargas);
                node.SetElementValue("Impressora", cbx_Impresora.SelectedValue);
            }
            Credenciales.Save(RutaArchivoXML);
        }

        //CARPETA DESCARGAS CONFIGURABLE
        private void btn_CambiarCarpetaDescargas_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectorCarpetas.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SelectorCarpetas.SelectedPath))
            {
                txtb_RutaCarpetaDescargas.Text = SelectorCarpetas.SelectedPath;
                foreach (XElement node in Credenciales.Descendants("Credencials"))
                {
                    node.SetElementValue("CarpetaBaixada", SelectorCarpetas.SelectedPath);
                }
                Credenciales.Save(RutaArchivoXML);
            }
        }

        //INICIAR LA CONSOLA Y PONERLA DENTRO DEL PANEL
        private void IniciarConsola()
        {
            Consola = Process.Start(Application.StartupPath + "\\ConsolaGestionFTP.exe", txtb_Servidor.Text.Trim() + " " + txtb_Usuario.Text.Trim() + " " + txtb_Contraseña.Text.Trim() + " " + CarpetaDescargas + " / /Tractats/");
            Thread.Sleep(100);
            App_Consola = Consola.MainWindowHandle;
            SetParent(App_Consola, pnl_consola.Handle);
            SetWindowLong(App_Consola, -16, 0x10000000);
            MoveWindow(App_Consola, 0, 0, pnl_consola.Width, pnl_consola.Height, true);
            
        }

        private void RecepcióDeComandes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Consola.Kill();
            Consola.Close();
            Application.Exit();
        }

        private void RecepcióDeComandes_Resize(object sender, EventArgs e)
        {
            if (this.App_Consola != IntPtr.Zero)
            {
                MoveWindow(App_Consola, 0, 0, pnl_consola.Width, pnl_consola.Height, true);
            }
        }
    }
}
