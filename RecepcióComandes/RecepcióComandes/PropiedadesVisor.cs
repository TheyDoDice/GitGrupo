using System;
using System.Drawing;
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

        private void PropiedadesVisor_Load(object sender, EventArgs e)
        {
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                txtb_colorPicker.BackColor = ColorTranslator.FromHtml(node.Element("ColorLineas").Value);
                trb_ancho.Value = Int32.Parse(node.Element("AnchoSangria").Value);
                lbl_trackbarValue.Text = node.Element("AnchoSangria").Value;
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
            trb_ancho.Value = 14;
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

        private void trb_ancho_ValueChanged(object sender, EventArgs e)
        {
            lbl_trackbarValue.Text = trb_ancho.Value.ToString();
            foreach (XElement node in ArchivoConfig.Descendants("ConfigVisor"))
            {
                node.SetElementValue("AnchoSangria", trb_ancho.Value);
            }
            ArchivoConfig.Save(RutaArchivoConfig);
        }
    }
}
