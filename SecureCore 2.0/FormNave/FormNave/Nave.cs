using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using BibliotecaPACS;

namespace FormNave
{
    public partial class Nave : Form
    {
        public int idNave { get; set; }
        public int idPlanet { get; set; }
        public string ipPlanet { get; set; }

        SContext context = new SContext();
        Dictionary<string, string> codificacio = new Dictionary<string, string>();

        public Nave()
        {
            InitializeComponent();
        }

        public Nave(int idNave, int idPlanet, string ipPlanet)
        {
            this.idNave = idNave;
            this.idPlanet = idPlanet;
            this.ipPlanet = ipPlanet;

            InitializeComponent();

            bttn_obtenirValidationCode.Enabled = false;
            bttn_EntregarPaquetes.Enabled = false;
            bttn_DescodificarrPaquetes.Enabled = false;
            bttn_downloadCodificacion.Enabled = false;



        }

        private void bttn_peticion_Click(object sender, EventArgs e)
        {
            bttn_obtenirValidationCode.Enabled = true;
            bttn_EntregarPaquetes.Enabled = true;
            bttn_DescodificarrPaquetes.Enabled = true;
            bttn_downloadCodificacion.Enabled = true;
        }

        private void bttn_DescodificarrPaquetes_Click(object sender, EventArgs e)
        {

        }

        private void bttn_EntregarPaquetes_Click(object sender, EventArgs e)
        {

        }

        private void bttn_downloadCodificacion_Click(object sender, EventArgs e)
        {
            Codificacio codificacioDLL = new Codificacio();

            codificacio = codificacioDLL.ObtenirCodificacio(idPlanet);
        }

        private void bttn_obtenirValidationCode_Click(object sender, EventArgs e)
        {
            Encriptacio encriptacio = new Encriptacio();
            string publicKey = context.PlanetKeys.Where(x => x.idPlanet == idPlanet).FirstOrDefault().XMLKey;
            string missatgeNau = context.ValidationCode.Where(x => x.idPlanet == idPlanet).FirstOrDefault().ValidationCode1;

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] missategeNauBytes = ByteConverter.GetBytes(missatgeNau);

            RSACryptoServiceProvider RSANau = new RSACryptoServiceProvider();
            RSANau.FromXmlString(publicKey);

            byte[] missatgeEncriptatNau = encriptacio.RSAEncrypt(missategeNauBytes, RSANau.ExportParameters(false), false);
        }

        private void btn_enviarMensajeEncriptado_Click(object sender, EventArgs e)
        {

        }
    }
}
