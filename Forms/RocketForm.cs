using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using PacsLibrary;

namespace Forms
{
    public partial class RocketForm : Form
    {
        //SERVIDOR Y CLIENTE
        ServerTCP serverTcp = new ServerTCP();
        ClientTCP clientTcp = new ClientTCP();

        int portChat = 8888;
        int portData = 8889;
        string ip = "172.17.21.169";
        string lastMessage = "";

        //COMPROVACIONS 1
        int idNau = 1;
        int idPlaneta = 2;
        private SContext context = new SContext();
        private Encriptacio encrypt = new Encriptacio();
        
        //COMPROVACIONS 2
        Dictionary<string, string> codificacio = new Dictionary<string, string>();
        string ruta = "";

        //PATH SALIDA
        string FolderPath    = Application.StartupPath + "\\Rocket\\unzipedPacs";
        string newFolderPath = Application.StartupPath + "\\Rocket\\Pacssol";

        //PATH ENTRADA
        string FilePathRecived = Application.StartupPath + "\\Rocket\\Recived\\PACS.zip";


        //CONSTRUCTOR
        public RocketForm(int idNave, int idPlanet) : base()
        {
            this.idNau = idNave;
            this.idPlaneta = idPlanet;
            this.ip = context.Planets.Where(x => x.idPlanet == idPlanet).FirstOrDefault().IPPlanet;
        }

        public RocketForm()
        {
            InitializeComponent();
        }

        private void RocketForm_Load(object sender, EventArgs e)
        {
            //INICIAR SERVIDOR   
            serverTcp.iniciarServer(tbx_console, portChat, portData, FilePathRecived, lbl_state);
            this.FormClosed += (se, ev) => { serverTcp.apagarServer(); };

            #region consola autoscroll
            tbx_console.TextChanged += (se, ev) =>
            {
                if (tbx_console.Visible)
                {
                    tbx_console.SelectionStart = tbx_console.TextLength;
                    tbx_console.ScrollToCaret();
                }
            };

            tbx_console.TextChanged += (se, ev) =>
            {
                try
                {
                    lastMessage = tbx_console.Text.Split('➖').LastOrDefault().Trim();
                }
                catch
                {
                }
            };
            #endregion
        }

        //ENVIAR MENSAJE
        private void btn_input_Click(object sender, EventArgs e)
        {
            //INICIAR CLIENTE
            clientTcp.setClient(ip, portChat);
            clientTcp.enviarChat(txb_input.Text, lbl_state);

            tbx_console.Text += Environment.NewLine + "[Mensaje Nave]      ➖ " + txb_input.Text;
            txb_input.Text = "";
        }
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            switch (lastMessage)
            {
                case "validationCode subido" :

                    encriptarValidationCode();
                    break;

                case "pacs subido":

                    desencriptarPacs();
                    break;

                default:

                    break;
            }
        }

        //FUNCIONES
        private void encriptarValidationCode()
        {
            string publicKey   = context.PlanetKeys.Where(x => x.idPlanet == idPlaneta).FirstOrDefault().XMLKey;
            string missatgeNau = context.ValidationCode.Where(x => x.idPlanet == idPlaneta).FirstOrDefault().ValidationCode1;

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] missategeNauBytes      = ByteConverter.GetBytes(missatgeNau);

            RSACryptoServiceProvider RSANau = new RSACryptoServiceProvider();
            RSANau.FromXmlString(publicKey);

            byte[] missatgeEncriptatNau = encrypt.RSAEncrypt(missategeNauBytes, RSANau.ExportParameters(false), false);

            MissatgesTCPIP missatgesTCPIP = new MissatgesTCPIP();
            string resposta = missatgesTCPIP.CrearMissatgeValidationKey(ByteConverter.GetString(missatgeEncriptatNau));

            //INICIAR CLIENTE
            clientTcp.setClient(ip, portChat);
            clientTcp.enviarChat(resposta, lbl_state);

            tbx_console.Text += Environment.NewLine + "[Mensaje Nave]      ➖ " + resposta;
            txb_input.Text = "";
        }

        private void desencriptarPacs()
        {
            Codificacio codificacioDLL = new Codificacio();
            codificacio = codificacioDLL.ObtenirCodificacio(idPlaneta);

            Fitxers fitxers = new Fitxers();
            fitxers.DescodificarFitxers(Directory.GetFiles(FolderPath), codificacio, newFolderPath);

        }
    }
}
