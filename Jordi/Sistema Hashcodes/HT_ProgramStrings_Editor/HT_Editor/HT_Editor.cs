using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HT_Editor
{
    public partial class HT_Editor : Form
    {
        private static List<string> ArchivoHashcodes;
        private string RutaArchivoHashcodes;
        bool guardado = true;

        public HT_Editor(string ruta)
        {
            InitializeComponent();
            RutaArchivoHashcodes = ruta;
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(RutaArchivoHashcodes))
            {
                try
                {
                    ArchivoHashcodes = File.ReadAllLines(RutaArchivoHashcodes).ToList();
                    cbx_HashCodesList.DataSource = ObtenerListaHashcodes();
                    cbx_sections.DataSource = ListarSecciones();
                    cbx_sections_delete.DataSource = ListarSecciones();
                    VisorHashcodes.DataSource = HashcodesToDatagridview(2);
                    VisorHashcodes.Sort(VisorHashcodes.Columns["Identificador"], ListSortDirection.Ascending);
                }
                catch
                {
                    MessageBox.Show("Ha habido un error al leer el archivo, intenta cargarlo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtb_HashcodeName.Text.Trim()))
            {
                try
                {
                    if (!String.IsNullOrEmpty(cbx_sections.SelectedItem.ToString().Trim()))
                    {
                        try
                        {
                            string identificador = ObtenerIdentificador();
                            AñadirLineaDataGridView(VisorHashcodes, txtb_HashcodeName.Text.Trim(), identificador);
                            ArchivoHashcodes.Insert(ArchivoHashcodes.IndexOf("/* End_" + cbx_sections.SelectedItem.ToString() + " */"), txtb_HashcodeName.Text.Trim() + "\t" + identificador);
                            cbx_HashCodesList.DataSource = ObtenerListaHashcodes();
                            guardado = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ha habido un error inesperado inténtalo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ninguna sección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("La sección seleccionada no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre no puede estar en blanco.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbx_HashCodesList.SelectedItem.ToString()))
                {
                    if (EliminarLineaDataGridView(VisorHashcodes, cbx_HashCodesList.SelectedItem.ToString()))
                    {
                        EliminarLineaProgramStrings(cbx_HashCodesList.SelectedItem.ToString());
                        guardado = false;
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al eliminar el Hashcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private List<string> ObtenerListaHashcodes()
        {
            List<string> hashcodes = new List<string>();
            hashcodes.Add("");
            
            foreach (string line in ArchivoHashcodes)
            {
                if (line.StartsWith("/*")||String.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    string[] col = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    hashcodes.Add(col[0]);
                }
            }

            return hashcodes;
        }

        public DataTable HashcodesToDatagridview(int numberOfColumns)
        {
            DataTable tbl = new DataTable();
            string name;

            for (int col = 0; col < numberOfColumns; col++)
            {
                if (col == 0)
                {
                    name = "Etiqueta";
                }
                else
                {
                    name = "Identificador";
                }

                tbl.Columns.Add(new DataColumn(name));
            }

            foreach (string line in ArchivoHashcodes)
            {
                if (line.StartsWith("/*") || String.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    var cols = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    DataRow dr = tbl.NewRow();
                    for (int cIndex = 0; cIndex < numberOfColumns; cIndex++)
                    {
                        dr[cIndex] = cols[cIndex];
                    }

                    tbl.Rows.Add(dr);
                }
            }

            return tbl;
        }

        private bool AñadirLineaDataGridView(DataGridView dataGridView, string HashcodeLabel, string HashcodeIdentifier)
        {
            bool correcte = false;
            try
            {
                DataTable dt = dataGridView.DataSource as DataTable;
                dt.Rows.Add(HashcodeLabel, HashcodeIdentifier);
                correcte = true;
            }
            catch
            { }

            return correcte;
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

        private void EliminarLineaProgramStrings(string hashcode)
        {
            ArchivoHashcodes.RemoveAll(u => u.StartsWith(hashcode));
        }

        private string ObtenerIdentificador()
        {
            int index = VisorHashcodes.Rows.Count - 1;
            long identificador;
            string hexString;

            if (index >= 0)
            {
                identificador = GetLastHash();
                if (identificador < 268435455)
                {
                    identificador += 1;
                    hexString = "0x" + identificador.ToString("X8");
                    ArchivoHashcodes[0] = "/* LastHash: " + hexString + " */";
                }
                else
                {
                    MessageBox.Show("Se ha llenado la sección, no hay más identificadores disponibles", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    hexString = null;
                }
            }
            else
            {
                hexString = "0x00000000";
            }

            return hexString;
        }

        private List<String> ListarSecciones()
        {
            List<String> lista = new List<String>();

            string[] sectionName;

            lista.Add("");
            foreach (string line in ArchivoHashcodes)
            {
                if (line.StartsWith("/* Section_"))
                {
                    sectionName = line.Split(new string[] { "/* "," */" }, StringSplitOptions.None);
                    lista.Add(sectionName[1]);
                }

            }

            return lista;
        }

        private void btn_AñadirSeccion_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtb_SectionName.Text))
            {
                try
                {
                    ArchivoHashcodes.Insert(ArchivoHashcodes.IndexOf("/* End_HT_Text */"), "/* " + lbl_prefixSection.Text + txtb_SectionName.Text.Trim() + " */");
                    ArchivoHashcodes.Insert(ArchivoHashcodes.IndexOf("/* End_HT_Text */"), "/* End_" + lbl_prefixSection.Text + txtb_SectionName.Text.Trim() + " */");
                    cbx_sections.DataSource = ListarSecciones();
                    cbx_sections_delete.DataSource = ListarSecciones();
                    guardado = false;
                }
                catch
                {
                    MessageBox.Show("Ha habido un error al añadir la sección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private long GetLastHash ()
        {
            long numero = 0;
            foreach (string line in ArchivoHashcodes)
            {
                if (line.StartsWith("/* LastHash: "))
                {
                    string[] value = line.Split(null);
                    numero = Convert.ToInt64(value[2], 16);
                }

            }
            return numero;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(RutaArchivoHashcodes);
            foreach (String s in ArchivoHashcodes)
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

        private void btn_deleteSection_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarSeccion(cbx_sections_delete.SelectedItem.ToString());
                guardado = false;
            }
            catch
            {
                MessageBox.Show("La sección seleccionada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarSeccion (string section)
        {
            if (!String.IsNullOrEmpty(cbx_sections_delete.SelectedItem.ToString()))
            {
                int inicio = ArchivoHashcodes.IndexOf("/* " + section + " */");
                int final = ArchivoHashcodes.IndexOf("/* End_" + section + " */") + 1;
                ArchivoHashcodes.RemoveRange(inicio, final - inicio);
                cbx_sections.DataSource = ListarSecciones();
                cbx_sections_delete.DataSource = ListarSecciones();
                cbx_HashCodesList.DataSource = ObtenerListaHashcodes();
                VisorHashcodes.DataSource = HashcodesToDatagridview(2);
                VisorHashcodes.Sort(VisorHashcodes.Columns["Identificador"], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna sección", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
