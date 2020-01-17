using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecepcióComandes
{
    public partial class PropiedadesVisor : Form
    {
        private static string RutaArchivoConfig = Application.StartupPath + "\\ConfigVisor.xml";
        private XDocument ArchivoConfig = XDocument.Load(RutaArchivoConfig);

        public PropiedadesVisor()
        {
            InitializeComponent();
        }

        private void txtb_colorPicker_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = SelectorColores.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtb_colorPicker.BackColor = SelectorColores.Color;
                foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
                {
                    node.SetElementValue("ColorLineas", ColorTranslator.ToHtml(SelectorColores.Color));
                }
                ArchivoConfig.Save(RutaArchivoConfig);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtb_sangria_TextChanged(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("AnchoSangria", txtb_sangria.Text);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }

        private void PropiedadesVisor_Load(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                txtb_colorPicker.BackColor = ColorTranslator.FromHtml(node.Element("ColorLineas").Value);
                txtb_sangria.Text = node.Element("AnchoSangria").Value;
                if (node.Element("MostrarLineas").Value.Equals("true"))
                {
                    rb_lines_yes.Checked = true;
                    rb_lines_no.Checked = false;
                }
                else
                {
                    rb_lines_yes.Checked = false;
                    rb_lines_no.Checked = true;
                }
                if (node.Element("BotonesNodos").Value.Equals("true"))
                {
                    rb_botones_yes.Checked = true;
                    rb_botones_no.Checked = false;
                }
                else
                {
                    rb_botones_yes.Checked = false;
                    rb_botones_no.Checked = true;
                }
            }
        }

        private void rb_lines_yes_Click(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("MostrarLineas", true);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }

        private void rb_lines_no_Click(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("MostrarLineas", false);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rb_lines_yes.Checked = true;
            rb_lines_no.Checked = false;
            txtb_sangria.Text = "14";
            txtb_colorPicker.BackColor = Color.White;

            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("ColorLineas", "White");
                node.SetElementValue("AnchoSangria", 14);
                node.SetElementValue("MostrarLineas", true);
                node.SetElementValue("BotonesNodos", true);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }

        private void rb_botones_yes_Click(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("BotonesNodos", true);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }

        private void rb_botones_no_Click(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("BotonesNodos", false);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }
    }
}
