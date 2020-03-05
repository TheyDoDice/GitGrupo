using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacsLibrary;
using PacsLibrary.BBDD;
using BBDD;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Security.Cryptography;

namespace Forms
{
    public partial class PlanetForm : Form
    {
        MissatgesTCPIP tCPIP = new MissatgesTCPIP();
        GestioBDD bDD = new GestioBDD();

        //SERVIDOR Y CLIENTE
        ServerTCP serverTcp = new ServerTCP();
        ClientTCP clientTcp = new ClientTCP();

        int portChat = 8888;
        int portData = 8889;
        string ip = "172.17.22.48";
        string lastMessage = "";

        //BOOLEANS COMPROVACIO
        bool boolDataCorrecta = false;
        bool boolMisatgeCorrecte = false;

        //COMPROVACIONS 1
        int idNau = 1;
        int idPlaneta = 2;
        private SContext context = new SContext();
        private Encriptacio encrypt = new Encriptacio();

        string privatekey;
        string missatgeInicial;

        //COMPROVACIONS 2
        Codificacio pacs = new Codificacio();
        Fitxers fitxers = new Fitxers();
        Dictionary<string, string> dicCodificacio = new Dictionary<string, string>();
        const int MidaFitxersPACS = 500000;
        const int NumFitxers = 3;

        //PATH SALIDA
        string FilePathLLetres = Application.StartupPath + "\\Planet\\FicherosTextos";
        string FilePathPACS    = Application.StartupPath + "\\Planet\\FicherosPACS";
        string FilePathZip     = Application.StartupPath + "\\Planet\\Zips";
        //PATH ENTRADA
        string FilePathRecived = Application.StartupPath + "\\Planet\\Recived\\PACS.zip";
        
        public PlanetForm()
        {
            InitializeComponent();
        }

        public PlanetForm(int idPlanet, string ip) : base()
        {
            this.idPlaneta = idPlanet;
            this.ip = ip;

            bDD.InsertPlanetIp(this.idPlaneta, this.ip);            
        }

        private void PlanetForm_Load(object sender, EventArgs e)
        {
            //INICIAR SERVIDOR   
            serverTcp.iniciarServer(txtb_consola, portChat, portData, FilePathRecived, lbl_state);
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

        //BOTONES ENVIAR
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
            switch (tCPIP.ObtenirTipusMissatge(lastMessage))
            {
                case MissatgesTCPIP.TipusMissatge.EntryRequirement:

                    PeticioEntrada();
                    break;

                case MissatgesTCPIP.TipusMissatge.ValidationKey:

                    DesencriptarMisatge();
                    if (boolMisatgeCorrecte)
                    {
                        EntregaPacs();
                    }
                    break;

                case MissatgesTCPIP.TipusMissatge.PacsSending:

                    //Rebre Fitxer PACSSOL.txt

                    //Comparar fitxer amb fixtersKey

                default:

                    //TipusMissatge.ERROR

                    break;
            }
        }

        //FUNCIO PER ENTRAR AL PLANETA
        private void PeticioEntrada()
        {
            idNau = Int32.Parse(tCPIP.ObtenirIdNau(lastMessage, MissatgesTCPIP.TipusMissatge.EntryRequirement));
            lbl_state.Text = "Verifying delivery date...";
            //PLANETA --> COMPROBAR DELIVERYDATA
            DeliveryData delivery = ObenirDeliveryData(idNau, idPlaneta);

            if (DeliryDataCorrecte(delivery))
            {
                //PLANETA --> GENERAR MISSATGE
                missatgeInicial = encrypt.GenerarRNG(100000);

                //PLANETA --> GENERAR CLAUS
                privatekey = encrypt.GenerarClaus(delivery, missatgeInicial, idPlaneta);

                //CONTESTAR A LA NAVE
                    //--> ENVIAR A LA NAVE EL MENSAJE PARA CONTINUAR
                boolDataCorrecta = true;
                lbl_state.Text = "Delivery date";
            }
            else
            {
                //DELIVERY DATA INCORRECTE
            }
        }

        //FUNCIO ENTREGA DEL MISATGE ENRIPTAT
        private void DesencriptarMisatge()
        {
            if (boolDataCorrecta)
            {
                //PLANETA --> DESENCRIPTAR MISSATGE NAU
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] missatgeEncriptatNau = ByteConverter.GetBytes(lastMessage); //pendiente substring del mensaje

                RSACryptoServiceProvider RSAPlaneta = new RSACryptoServiceProvider();
                RSAPlaneta.FromXmlString(privatekey);

                string missatgeDesencriptat = ByteConverter.GetString(encrypt.RSADecrypt(missatgeEncriptatNau, RSAPlaneta.ExportParameters(true), false));

                if (missatgeDesencriptat == missatgeInicial)
                {
                    //--> ENVIAR A LA NAVE EL MENSAJE PARA CONTINUAR
                    boolMisatgeCorrecte = true;
                }
                else
                {
                    //MAL
                }
            }
        }

        //FUNCIONS ENTREGA PACS
        private void EntregaPacs()
        {
            //CREAR DICCIONARI
            dicCodificacio = pacs.CrearCodificacio(999);
            Stopwatch Cronometro = Stopwatch.StartNew();

            CrearCarpetas();
            fitxers.GenerarFitxerPacs(MidaFitxersPACS, dicCodificacio, FilePathPACS, FilePathLLetres, NumFitxers);

            if (File.Exists(FilePathZip + "\\PACS.zip"))
            {
                File.Delete(FilePathZip + "\\PACS.zip");
            }

            ZipFile.CreateFromDirectory(FilePathPACS, FilePathZip + "\\PACS.zip");

            //INICIAR CLIENTE
            clientTcp.setClient(ip, portData);
            clientTcp.enviarData(FilePathZip + "\\PACS.zip", lbl_state);

            //GUARDAR DADES EN BBDD
            pacs.GuardarCodificacioBBDD(idPlaneta, dicCodificacio);

            Cronometro.Stop();

            txtb_consola.Text += Environment.NewLine + "Archivos creados correctamente";
            txtb_consola.Text += Environment.NewLine + "el proceso ha tardado: " + Cronometro.ElapsedMilliseconds + "ms";
        }

        //FUNCIONS DELIVERYDATA
        private bool DeliryDataCorrecte(DeliveryData delivery)
        {
            return delivery != null ? true : false;
        }

        // ----Falta el dia
        private DeliveryData ObenirDeliveryData(int idNave, int idPlaneta)
        {
            return context.DeliveryData.Where(x => x.idPlanetDest == idPlaneta && x.idSpaceShip == idNave).FirstOrDefault();
        }

        //FUNCIO PER AGAFAR LA IMATGE
        private Image TakeImg(string name)
        {
            string dir = Path.GetDirectoryName(Application.StartupPath + "\\Img\\NewSecureCore\\");
            return Image.FromFile(dir + "\\" + name + ".png");
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
            if (!Directory.Exists(FilePathZip))
            {
                Directory.CreateDirectory(FilePathZip);
            }
        }
    }
}
