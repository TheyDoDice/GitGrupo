using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace CompararArchivos
{
    public partial class Form1 : Form
    {
        //Declarar variables
        bool iguales = false;
        string hash1, hash2;
        OpenFileDialog ExploradorArchivos = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CargarArchivo1_Click(object sender, EventArgs e)
        {
            //Abrir explorador archivos y poner la ruta en el textbox
            if (ExploradorArchivos.ShowDialog() == DialogResult.OK)
            {
                txtb_RutaArchivo1.Text = ExploradorArchivos.FileName;
            }
        }

        private void btn_CargarArchivo2_Click(object sender, EventArgs e)
        {
            //Abrir explorador archivos y poner la ruta en el textbox
            if (ExploradorArchivos.ShowDialog() == DialogResult.OK)
            {
                txtb_RutaArchivo2.Text = ExploradorArchivos.FileName;
            }
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            //Comprobar si existen los archivos y si es así compararlos
            if (File.Exists(txtb_RutaArchivo1.Text) &&File.Exists(txtb_RutaArchivo2.Text))
            {
                //Limpiar Consola
                Consola.Clear();

                //Comparar Archivos
                Stopwatch Cronometro = Stopwatch.StartNew();
                    hash1 = GetMD5HashFromFile(txtb_RutaArchivo1.Text);
                    hash2 = GetMD5HashFromFile(txtb_RutaArchivo2.Text);

                    if (hash1 == hash2)
                    {
                        iguales = true;
                    }

                Cronometro.Stop();

                //Imprimir Resultados
                if (iguales)
                {
                    Consola.Text += "Resultado de la comparación: Son iguales" + Environment.NewLine;
                    Consola.Text += "Tiempo transcurrido: " + Cronometro.ElapsedMilliseconds + "ms" + Environment.NewLine;
                    Consola.Text += "Hash del archivo 1: " + hash1 + Environment.NewLine;
                    Consola.Text += "Hash del archivo 2: " + hash2;
                }
                else
                {
                    Consola.Text += "Resultado de la comparación: No son iguales" + Environment.NewLine;
                    Consola.Text += "Tiempo transcurrido: " + Cronometro.ElapsedMilliseconds + "ms" + Environment.NewLine;
                    Consola.Text += "Hash del archivo 1: " + hash1 + Environment.NewLine;
                    Consola.Text += "Hash del archivo 2: " + hash2;
                }
            }
            else
            {
                MessageBox.Show("Ha habido un error al leer los archivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string GetMD5HashFromFile(string NombreArchivo)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (FileStream Stream = File.OpenRead(NombreArchivo))
                {
                    byte[] Hash = md5.ComputeHash(Stream);
                    return BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
            }
        }
    }
}
