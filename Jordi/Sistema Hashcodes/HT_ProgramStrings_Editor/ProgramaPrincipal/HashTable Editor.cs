using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgramaPrincipal
{
    public partial class HashTableEditor : Form
    {
        public HashTableEditor()
        {
            InitializeComponent();
        }

        private static string RutaArchivo = Application.StartupPath + "\\Config.xml";
        private XDocument ArchivoConfig = XDocument.Load(RutaArchivo);
        private static string RutaHashcodes;
        private static string RutaProgramStrings;
        private static string RutaProgramColors;

        private void HashTableEditor_Load(object sender, EventArgs e)
        {
            comprovar_rutas();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editorTextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprovar_rutas();
            if (!String.IsNullOrEmpty(RutaProgramStrings)|| String.IsNullOrEmpty(RutaHashcodes))
            {
                HT_ProgramStrings_Editor.HT_ProgramStrings_Editor StringsForm = new HT_ProgramStrings_Editor.HT_ProgramStrings_Editor(RutaHashcodes, RutaProgramStrings);
                StringsForm.MdiParent = this;
                StringsForm.Show();
            }
            else
            {
                MessageBox.Show("La ruta a los archivos es incorrecta. Cambia la ruta en el menú Archivo -> Preferencias -> Rutas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editorHashcodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprovar_rutas();
            if (!String.IsNullOrEmpty(RutaHashcodes))
            {
                HT_Editor.HT_Editor HashcodesForm = new HT_Editor.HT_Editor(RutaHashcodes);
                HashcodesForm.MdiParent = this;
                HashcodesForm.Show();
            }
            else
            {
                MessageBox.Show("La ruta a los archivos es incorrecta. Cambia la ruta en el menú Archivo -> Preferencias -> Rutas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rutas RutasForm = new Rutas();
            RutasForm.MdiParent = this;
            RutasForm.Show();
        }

        private void editorColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprovar_rutas();
            if (!String.IsNullOrEmpty(RutaProgramColors) || String.IsNullOrEmpty(RutaHashcodes))
            {
                HT_ProgramColors_Editor.HT_ProgramColors_Editor ColorsForm = new HT_ProgramColors_Editor.HT_ProgramColors_Editor(RutaHashcodes, RutaProgramColors);
                ColorsForm.MdiParent = this;
                ColorsForm.Show();
            }
            else
            {
                MessageBox.Show("La ruta a los archivos es incorrecta. Cambia la ruta en el menú Archivo -> Preferencias -> Rutas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comprovar_rutas()
        {
            foreach (XElement node in ArchivoConfig.Descendants("Files"))
            {
                if (File.Exists(node.Element("Hashcodes").Value))
                {
                    RutaHashcodes = node.Element("Hashcodes").Value;
                }
                if (File.Exists(node.Element("ProgramStrings").Value))
                {
                    RutaProgramStrings = node.Element("ProgramStrings").Value;
                }
                if (File.Exists(node.Element("ProgramColors").Value))
                {
                    RutaProgramColors = node.Element("ProgramColors").Value;
                }

            }
        }
    }
}
