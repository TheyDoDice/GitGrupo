using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HT_ProgramStrings_Editor
{
    public partial class HT_ProgramStrings_Editor : Form
    {

        private List<string> ArchivoStrings = new List<string>();
        private Hashtable Hashcodes = new Hashtable();
        private string RutaArchivoHashcodes;
        private string RutaArchivoProgramStrings;
        bool guardado = true;

        public HT_ProgramStrings_Editor(string RutaHashcodes, string RutaStrings)
        {
            InitializeComponent();
            RutaArchivoHashcodes = RutaHashcodes;
            RutaArchivoProgramStrings = RutaStrings;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(RutaArchivoHashcodes))
            {
                Hashcodes = ObtenerListaHashcodes();
                cbx_HashCodesList.DataSource = ListaKeysHashcode();
                ArchivoStrings = LeerArchivoTextos();
                ArchivoToDatagridview();
            }
            else
            {
                MessageBox.Show("Archivo Hashcodes no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (File.Exists(RutaArchivoProgramStrings))
            {

            }
            else
            {
                MessageBox.Show("Archivo Strings no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List <string> LeerArchivoTextos()
        {
            string[] archivo = File.ReadAllLines(RutaArchivoProgramStrings);

            foreach (string line in archivo)
            {
                if (!(line.StartsWith("/*")||String.IsNullOrEmpty(line)))
                {
                    ArchivoStrings.Add(line);
                }
            }

            return ArchivoStrings;
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
                    lista.Add(col[0],col[1]);
                }
            }

            return lista;
        }

        private List<string> ListaKeysHashcode()
        {
            List<string> list = new List<string>();
            {
                foreach(DictionaryEntry key in Hashcodes)
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

        private void ArchivoToDatagridview()
        {
            string[] cols;
            string etiqueta;
            string[] NombresColumnas = new string[] { "Hashcode", "Inglés", "Español", "Catalán" };

            foreach (string nombre in NombresColumnas)
            {
                DGV_ProgramStrings.Columns.Add(nombre, nombre);
            }

            foreach (string item in ArchivoStrings)
            {
                cols = item.Split(new string[] { "--HT_String_Delimiter--" }, StringSplitOptions.None);
                etiqueta = ObtenerEtiqueta(cols[0]);
                DGV_ProgramStrings.Rows.Add(etiqueta, cols[1], cols[2],cols[3]);
            }
        }

        private void btn_AddToFile_Click(object sender, EventArgs e)
        {
            string identificador;
            try
            {
                if(!(string.IsNullOrEmpty(cbx_HashCodesList.SelectedItem.ToString()) || string.IsNullOrEmpty(txtb_English.Text) || string.IsNullOrEmpty(txtb_Spanish.Text) || string.IsNullOrEmpty(txtb_Catalan.Text)))
                {
                    identificador = ObtenerIdentificadorHashcode(cbx_HashCodesList.SelectedItem.ToString());
                    string line = identificador + "--HT_String_Delimiter--" + txtb_English.Text + "--HT_String_Delimiter--" + txtb_Spanish.Text + "--HT_String_Delimiter--" + txtb_Catalan.Text;
                    if (!ArchivoStrings.Any(o => o.StartsWith(identificador)))
                    {
                        ArchivoStrings.Add(line);
                        DGV_ProgramStrings.Rows.Add(cbx_HashCodesList.SelectedItem.ToString(), txtb_English.Text, txtb_Spanish.Text, txtb_Catalan.Text);
                        guardado = false;
                    }
                    else
                    {
                        MessageBox.Show("El hashcode seleccionado ya está insertado en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error al insertar el texto, no puede haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("No se puede insertar el texto porque hay campos vacíos o incorrectos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbx_HashCodesList.SelectedItem.ToString()))
                {
                    ArchivoStrings.RemoveAll(u => u.StartsWith(cbx_HashCodesList.SelectedItem.ToString()));
                    EliminarLineaDataGridView(DGV_ProgramStrings, cbx_HashCodesList.SelectedItem.ToString());
                    guardado = false;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningun Hashcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("El hashcode seleccionado no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool EliminarLineaDataGridView(DataGridView dataGridView, string Hashcode)
        {
            bool correcte = false;
            try
            {
                DataTable dt = dataGridView.DataSource as DataTable;

                for (int v = 0; v < dataGridView.Rows.Count; v++)
                {
                    if (string.Equals(dataGridView[0, v].Value as string, Hashcode))
                    {
                        dataGridView.Rows.RemoveAt(v);
                        correcte = true;
                        v--;
                    }
                }
            }
            catch
            { }

            return correcte;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(RutaArchivoProgramStrings);
            foreach (String s in ArchivoStrings)
            {
                tw.WriteLine(s);
            }
            tw.Close();
            guardado = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardado == false)
            {
                DialogResult pregunta = MessageBox.Show("¿Quieres cerrar el programa sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    guardado = true;
                    this.Close();
                }
                else if (pregunta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
