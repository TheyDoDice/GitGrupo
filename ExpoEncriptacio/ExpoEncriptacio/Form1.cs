using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpoEncriptacio
{
    public partial class Form1 : Form
    {
        //VARIABLES
        Encriptar encript;
        byte[] byteArraySalt;
        byte[] byteArrayhash;
        string contra;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            encript = new Encriptar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contra = contraseña.Text;
            byteArraySalt = encript.GenerateSalt();
            salt.Text = Convert.ToBase64String(byteArraySalt);

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byteArrayhash = encript.ComputeHash(contra, byteArraySalt);
            hash.Text = Convert.ToBase64String(byteArrayhash);

            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToBase64String(encript.ComputeHash(login.Text, Convert.FromBase64String(salt2.Text)));
            //FUNCION QUE CON LA CONTRASEÑA Y EL SALTA GENERA UN HASH
            // Y ESTE SE COMPARA CON EL HASH ANTERIOR
            if (encript.VerifyPassword(login.Text, Convert.FromBase64String(salt2.Text), byteArrayhash))
            {
                correcto.Text = "CORRECTO";
                correcto.ForeColor = Color.Green;
            }
            else
            {
                correcto.Text = "INCORRECTO";
                correcto.ForeColor = Color.Red;
            }
        }

        private void salt_TextChanged(object sender, EventArgs e)
        {
            salt2.Text = salt.Text;
        }
    }
}
