﻿using System;
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
using System.Xml.Linq;

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

        #endregion

        #region FUNCIONES PARA EL VISOR DE ARCHIVOS

        private TreeNode CreateDirectoryNode(string path, string name)
        {
            var directoryNode = new TreeNode(name);
            var directoryListing = GetDirectoryListing(path);

            var directories = directoryListing.Where(d => d.IsDirectory);
            var files = directoryListing.Where(d => !d.IsDirectory);

            foreach (var dir in directories)
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(dir.FullPath, dir.Name));
            }
            foreach (var file in files)
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name).ToString(), file.Name.ToString(), 1, 1);
            }
            return directoryNode;
        }

        public class FTPListDetail
        {
            public bool IsDirectory
            {
                get
                {
                    return !string.IsNullOrWhiteSpace(Dir) && Dir.ToLower().Equals("d");
                }
            }
            internal string Dir { get; set; }
            public string Permission { get; set; }
            public string Filecode { get; set; }
            public string Owner { get; set; }
            public string Group { get; set; }
            public string Name { get; set; }
            public string FullPath { get; set; }
        }

        public IEnumerable<FTPListDetail> GetDirectoryListing(string rootUri)
        {
            var CurrentRemoteDirectory = rootUri;
            var result = new StringBuilder();
            var request = GetWebRequest(WebRequestMethods.Ftp.ListDirectoryDetails, CurrentRemoteDirectory);
            using (var response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        result.Append(line);
                        result.Append("\n");
                        line = reader.ReadLine();
                    }
                    if (string.IsNullOrEmpty(result.ToString()))
                    {
                        return new List<FTPListDetail>();
                    }
                    result.Remove(result.ToString().LastIndexOf("\n"), 1);
                    var results = result.ToString().Split('\n');
                    string regex =
                        @"^" +               //# Start of line
                        @"(?<dir>[\-ld])" +          //# File size          
                        @"(?<permission>[\-rwx]{9})" +            //# Whitespace          \n
                        @"\s+" +            //# Whitespace          \n
                        @"(?<filecode>\d+)" +
                        @"\s+" +            //# Whitespace          \n
                        @"(?<owner>\w+)" +
                        @"\s+" +            //# Whitespace          \n
                        @"(?<group>\w+)" +
                        @"\s+" +            //# Whitespace          \n
                        @"(?<size>\d+)" +
                        @"\s+" +            //# Whitespace          \n
                        @"(?<month>\w{3})" +          //# Month (3 letters)   \n
                        @"\s+" +            //# Whitespace          \n
                        @"(?<day>\d{1,2})" +        //# Day (1 or 2 digits) \n
                        @"\s+" +            //# Whitespace          \n
                        @"(?<timeyear>[\d:]{4,5})" +     //# Time or year        \n
                        @"\s+" +            //# Whitespace          \n
                        @"(?<filename>(.*))" +            //# Filename            \n
                        @"$";                //# End of line

                    var myresult = new List<FTPListDetail>();
                    foreach (var parsed in results)
                    {
                        var split = new Regex(regex)
                            .Match(parsed);
                        var dir = split.Groups["dir"].ToString();
                        var permission = split.Groups["permission"].ToString();
                        var filecode = split.Groups["filecode"].ToString();
                        var owner = split.Groups["owner"].ToString();
                        var group = split.Groups["group"].ToString();
                        var filename = split.Groups["filename"].ToString();
                        myresult.Add(new FTPListDetail()
                        {
                            Dir = dir,
                            Filecode = filecode,
                            Group = group,
                            FullPath = CurrentRemoteDirectory + "/" + filename,
                            Name = filename,
                            Owner = owner,
                            Permission = permission,
                        });
                    };
                    return myresult;
                }
            }
        }

        private FtpWebRequest GetWebRequest(string method, string uri)
        {
            Uri serverUri = new Uri(uri);
            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                return null;
            }
            var reqFTP = (FtpWebRequest)FtpWebRequest.Create(serverUri);
            reqFTP.Method = method;
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(txtb_Usuario.Text.Trim(), txtb_Contraseña.Text.Trim());
            reqFTP.Proxy = null;
            reqFTP.KeepAlive = false;
            reqFTP.UsePassive = false;
            return reqFTP;
        }

        #endregion

        #region FUNCIONES SUBIR ARCHIVOS Y CREAR CARPETAS

        //Función para crear una carpeta en el servidor FTP
        private void CrearCarpeta(string ip_servidor, string nombre_carpeta, string usuario, string contraseña)
        {
            FtpWebRequest CrearCarpeta = (FtpWebRequest)WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", ip_servidor, nombre_carpeta)));
            CrearCarpeta.Credentials = new NetworkCredential(usuario, contraseña);
            CrearCarpeta.Method = WebRequestMethods.Ftp.MakeDirectory;
            FtpWebResponse ftpResponse = (FtpWebResponse)CrearCarpeta.GetResponse();
        }

        //Funcion para subir un archivo a una carpeta FTP
        private void SubirArchivoCarpeta(string ip_servidor, string nombre_carpeta, string rutaAbsolutaArchivo, string nombreArchivo, string usuario, string contraseña)
        {
            FtpWebRequest SubirArchivo = (FtpWebRequest)WebRequest.Create("ftp://" + ip_servidor + "/" + nombre_carpeta + "/" + nombreArchivo);
            SubirArchivo.Credentials = new NetworkCredential(usuario, contraseña);
            SubirArchivo.Method = WebRequestMethods.Ftp.UploadFile;
            FtpWebResponse ftpResponse = (FtpWebResponse)SubirArchivo.GetResponse();

            using (Stream fileStream = File.OpenRead(rutaAbsolutaArchivo))
            using (Stream ftpStream = SubirArchivo.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }
        }
#endregion

        private Image TakeImg(string mode, string name)
        {
            return Image.FromFile(Application.StartupPath + "\\Img\\" + mode + "_" + name + ".png");
        }

        //Ruta donde se generará el XML con las credenciales
        private static string RutaArchivoXML = Application.StartupPath + "\\credenciales.xml";

        //Ruta donde se guardarán los archivos descargados
        private static string CarpetaDescargas = Application.StartupPath + "\\Descargas";

        //Objeto para leer los XML
        private XDocument Credenciales = XDocument.Load(RutaArchivoXML);

        //Explorador de Carpetas
        private FolderBrowserDialog SelectorCarpetas = new FolderBrowserDialog();

        //Explorador de Archivos
        private OpenFileDialog ExploradorArchivos = new OpenFileDialog();
        private Uri CadenaConnexionFTP = new Uri("ftp://8.8.8.8/");

        //Codigo que se ejecuta al inicio
        private void RecepcióDeComandes_Load(object sender, EventArgs e)
        {
            //Lista de imagenes para el visor de archivos
            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\carpeta.png"));
            myImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Img\\archivo.png"));
            VisorArchivos.ImageList = myImageList;

            //Leer datos XML y ponerlos en los Textbox
            foreach (XElement node in Credenciales.Descendants("Credencials"))
            {
                txtb_Servidor.Text = node.Element("IP").Value;
                txtb_Puerto.Text = node.Element("Port").Value;
                txtb_Usuario.Text = node.Element("User").Value;
                txtb_Contraseña.Text = node.Element("Password").Value;
                txtb_RutaCarpetaDescargas.Text = node.Element("CarpetaBaixada").Value;
            }

            //Objeto conexión 
            CadenaConnexionFTP = new Uri("ftp://" + txtb_Servidor.Text + "/");
    }

        //Botón para cambiar la ruta donde se guardan los archivos descargados
        private void btn_CambiarCarpetaDescargas_Click(object sender, EventArgs e)
        {
            //Abrir explorador de carpetas 
            DialogResult result = SelectorCarpetas.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SelectorCarpetas.SelectedPath))
            {
                //Cambiar y guardar la ruta
                txtb_RutaCarpetaDescargas.Text = SelectorCarpetas.SelectedPath;
                foreach (XElement node in Credenciales.Descendants("Credencials"))
                {
                    node.SetElementValue("CarpetaBaixada", SelectorCarpetas.SelectedPath);
                }

                Credenciales.Save(RutaArchivoXML);
            }
        }

        //Botón guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            string serv, user, pass, port;

            //Leer datos de los textbox
            pass = txtb_Contraseña.Text.Trim();
            serv = txtb_Servidor.Text.Trim();
            user = txtb_Usuario.Text.Trim();

            //Si el textbox puerto está en blanc ficar el port predeterminat
            if (string.IsNullOrEmpty(txtb_Puerto.Text.Trim()))
            {
                port = "21"; //Puerto predeterminado para FTP
            }
            else
            {
                port = txtb_Puerto.Text;
            }

            /*DADES FTP:  -IP: 172.17.6.0     -User: g02      -Pass: 12345aA      -Port: 22*/

            //Escribir credenciales en el XML
            foreach (XElement node in Credenciales.Descendants("Credencials"))
            {
                node.SetElementValue("IP", serv);
                node.SetElementValue("Port", port);
                node.SetElementValue("User", user);
                node.SetElementValue("Password", pass);
                node.SetElementValue("CarpetaBaixada", CarpetaDescargas);
            }
            Credenciales.Save(RutaArchivoXML);
        }

        //Botón para conectarse y comprobar si hay cambios en los archivos
        private void btn_Check_Click(object sender, EventArgs e)
        {
            VisorArchivos.BeginUpdate();
            VisorArchivos.Nodes.Clear();
            VisorArchivos.Nodes.Add(CreateDirectoryNode(CadenaConnexionFTP.ToString(), "Directori Principal"));
            VisorArchivos.EndUpdate();
        }

        //Explorador archivos para subir al servidor      
        private void btn_AbrirArchivos_Click(object sender, EventArgs e)
        {
            string RutaArchivo;

            //Abrir Explorador de Archivos
            ExploradorArchivos.InitialDirectory = "C:\\";
            ExploradorArchivos.Filter = "Archivos EDI (*.EDI)|*.EDI|All files (*.*)|*.*";
            ExploradorArchivos.FilterIndex = 0;
            ExploradorArchivos.RestoreDirectory = true;

            if (ExploradorArchivos.ShowDialog() == DialogResult.OK)
            {
                //Guardar ruta del archivo seleccionado
                RutaArchivo = ExploradorArchivos.FileName;

                //CrearCarpeta
                CrearCarpeta(txtb_Servidor.Text.Trim(), "testFolder", txtb_Usuario.Text.Trim(), txtb_Contraseña.Text.Trim());

                //SubirArchivo a esa carpeta
                SubirArchivoCarpeta(txtb_Servidor.Text.Trim(), "testFolder", RutaArchivo, ExploradorArchivos.SafeFileName, txtb_Usuario.Text.Trim(), txtb_Contraseña.Text.Trim());
            }
        }
    }
}
