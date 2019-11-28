using System;
using System.Windows.Forms;
using System.IO;
namespace RecepcióComandes
{
    public partial class RecepcióDeComandes : Form
    {
        public RecepcióDeComandes()
        {
            InitializeComponent();
        }

        //Ruta on es generará el arxiu amb les credencials.
        private static string RutaArxiuEdi = Application.StartupPath + "\\credenciales.txt";

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            string serv, user, pass, port, e_serv, e_user, e_pass, e_port;

            //Llegir dades Textbox
            pass = txtb_contraseña.Text;
            serv = txtb_Servidor.Text;
            user = txtb_user.Text;
            port = txtb_puerto.Text;

            //Encriptar valors i escriure Dades Arxiu .txt
            e_serv = Encriptar(serv);
            e_user = Encriptar(user);
            e_pass = Encriptar(pass);
            e_port = Encriptar(port);

            string[] lines = {e_serv, e_user, e_pass, e_port};
            System.IO.File.WriteAllLines(RutaArxiuEdi, lines);
        }

        private void RecepcióDeComandes_Load(object sender, EventArgs e)
        {
            //Comprovar si l' arxiu existeix.
            if (File.Exists(RutaArxiuEdi))
            {
                //Declarar variables
                string[] dades = new string[4];
                string desencriptar_dada;
                int i = 0;

                //Llegir l' arxiu i guardar les dades en un Array de 4
                string[] lines = System.IO.File.ReadAllLines(RutaArxiuEdi);
                foreach (string line in lines)
                {
                    desencriptar_dada = DesEncriptar(line);
                    dades[i] = desencriptar_dada;
                    i++;
                }

                //Omplir els textbox amb les dades del Array
                txtb_Servidor.Text = dades[0];
                txtb_user.Text = dades[1];
                txtb_contraseña.Text = dades[2];
                txtb_puerto.Text = dades[3];
            }
        }

        /// Encripta una cadena
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
