using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgramaPrincipal
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }

        private static string RutaArchivo = Application.StartupPath + "\\Config.xml";
        private XDocument ArchivoConfig = XDocument.Load(RutaArchivo);


        private void Rutas_Load(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("Files"))
            {
                if (File.Exists(node.Element("Hashcodes").Value))
                {
                    tb_HashcodesFileRoute.Text = node.Element("Hashcodes").Value;
                }
                if (File.Exists(node.Element("ProgramStrings").Value))
                {
                    tb_ProgramStrings.Text = node.Element("ProgramStrings").Value;
                }
                if (File.Exists(node.Element("ProgramColors").Value))
                {
                    tb_ProgramColors.Text = node.Element("ProgramColors").Value;
                }

            }
        }

        private void btn_LoadTextFile_Click(object sender, EventArgs e)
        {
            tb_ProgramStrings.Text = BuscarArchivo();
            if (File.Exists(tb_ProgramStrings.Text.Trim()))
            {
                try
                {
                    foreach (XElement node in ArchivoConfig.Descendants("Files"))
                    {
                        node.SetElementValue("ProgramStrings", tb_ProgramStrings.Text);
                    }
                    ArchivoConfig.Save(RutaArchivo);
                }
                catch
                {
                    MessageBox.Show("Ha habido un error al leer el archivo, intenta cargarlo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                tb_ProgramStrings.Text = "";
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_loadHashcodes_Click(object sender, EventArgs e)
        {
            tb_HashcodesFileRoute.Text = BuscarArchivo();
            if (File.Exists(tb_HashcodesFileRoute.Text.Trim()))
            {
                foreach (XElement node in ArchivoConfig.Descendants("Files"))
                {
                    node.SetElementValue("Hashcodes", tb_HashcodesFileRoute.Text);
                }
                ArchivoConfig.Save(RutaArchivo);
            }
            else
            {
                tb_HashcodesFileRoute.Text = "";
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_loadColores_Click(object sender, EventArgs e)
        {
            tb_ProgramColors.Text = BuscarArchivo();
            if (File.Exists(tb_HashcodesFileRoute.Text.Trim()))
            {
                foreach (XElement node in ArchivoConfig.Descendants("Files"))
                {
                    node.SetElementValue("ProgramColors", tb_ProgramColors.Text);
                }
                ArchivoConfig.Save(RutaArchivo);
            }
            else
            {
                tb_ProgramColors.Text = "";
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string BuscarArchivo()
        {
            string filePath = null;

            OpenFileDialog ExploradorArchivos = new OpenFileDialog();
            ExploradorArchivos.InitialDirectory = Application.StartupPath;
            ExploradorArchivos.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ExploradorArchivos.FilterIndex = 2;
            ExploradorArchivos.RestoreDirectory = true;

            if (ExploradorArchivos.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = ExploradorArchivos.FileName;
            }

            return filePath;
        }
    }
}
