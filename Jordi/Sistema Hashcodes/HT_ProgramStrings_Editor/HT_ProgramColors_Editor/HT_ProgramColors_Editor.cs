using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HT_ProgramColors_Editor
{
    public partial class HT_ProgramColors_Editor : Form
    {
        private List<string> ArchivoColores = new List<string>();
        private Hashtable Hashcodes = new Hashtable();
        private string RutaArchivoHashcodes;
        private string RutaArchivoProgramStrings;
        ColorDialog MyDialog = new ColorDialog();
        public HT_ProgramColors_Editor(string RutaHashcodes, string RutaStrings)
        {
            InitializeComponent();
            RutaArchivoHashcodes = RutaHashcodes;
            RutaArchivoProgramStrings = RutaStrings;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(RutaArchivoHashcodes))
            {
                ArchivoColores = LeerArchivoTextos();
                Hashcodes = ObtenerListaHashcodes();
                ListaHashcodes.DataSource = ListaKeysHashcode();
            }
            else
            {
                MessageBox.Show("Archivo Hashcodes no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Hashtable ObtenerListaHashcodes()
        {
            Hashtable lista = new Hashtable();
            string[] lines = File.ReadAllLines(RutaArchivoHashcodes);
            foreach (string line in lines)
            {
                if (line.StartsWith("/*"))
                {
                    continue;
                }
                else
                {
                    string[] col = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    lista.Add(col[0], col[1]);
                }
            }

            return lista;
        }

        private List<string> ListaKeysHashcode()
        {
            List<string> list = new List<string>();
            {
                foreach (DictionaryEntry key in Hashcodes)
                {
                    list.Add(key.Key.ToString());
                }
            }

            return list;
        }

        public string ObtenerIdentificadorHashcode(string NombreHashCode)
        {
            string value = NombreHashCode;

            if (Hashcodes.ContainsKey(NombreHashCode))
            {
                value = Hashcodes[NombreHashCode].ToString();
            }

            return value;
        }

        public string ObtenerEtiqueta(string numero)
        {
            string valor = "Error";
            foreach (DictionaryEntry dictionaryEntry in Hashcodes)
            {
                if (numero.Equals(dictionaryEntry.Value.ToString()))
                {
                    valor = dictionaryEntry.Key.ToString();
                    break;
                }
            }

            return valor;
        }

        private List<string> LeerArchivoTextos()
        {
            string[] archivo = File.ReadAllLines(RutaArchivoProgramStrings);

            foreach (string line in archivo)
            {
                if (!(line.StartsWith("/*") || String.IsNullOrEmpty(line)))
                {
                    ArchivoColores.Add(line);
                }
            }

            return ArchivoColores;
        }

        private void txtb_backcolor_Click(object sender, EventArgs e)
        {
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = txtb_backcolor.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                txtb_backcolor.BackColor = MyDialog.Color;
            }
        }

        private void txtb_forecolor_Click(object sender, EventArgs e)
        {
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = txtb_forecolor.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                txtb_forecolor.BackColor = MyDialog.Color;
            }
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            string cadena, identificador;

            foreach (string items in ListaHashcodes.SelectedItems)
            {
                Hashcodes = ObtenerListaHashcodes();
                identificador = ObtenerIdentificadorHashcode(items);
                if (!ArchivoColores.Any(o => o.StartsWith(identificador)))
                {
                    cadena = identificador + "--HT_String_Delimiter--" + ColorTranslator.ToHtml(txtb_backcolor.BackColor).ToString() + "--HT_String_Delimiter--" + ColorTranslator.ToHtml(txtb_forecolor.BackColor).ToString();
                    ArchivoColores.Add(cadena);
                }
                else
                {
                    MessageBox.Show("El hashcode seleccionado ya está insertado en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(RutaArchivoProgramStrings);
            foreach (String s in ArchivoColores)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }
    }
}
