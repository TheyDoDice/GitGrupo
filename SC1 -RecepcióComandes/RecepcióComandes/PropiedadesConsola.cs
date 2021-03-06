﻿using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml.Linq;
using Hashcodes;

namespace RecepcióComandes
{
    public partial class PropiedadesConsola : Form
    {
        private static string RutaArchivoConfig = Application.StartupPath + "\\ConfigConsola.xml";
        private XDocument ArchivoConfig = XDocument.Load(RutaArchivoConfig);
        HashCodes hash = new HashCodes(Application.StartupPath + "\\Hashcodes\\hashcodes.h", Application.StartupPath + "\\Hashcodes\\ProgramStrings.txt");
        private static Hashtable HT = new Hashtable();
        private string[] TextColors = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray",
        "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow", "Gray", "Green", "Magenta", "Red", "White","Yellow" };

        private string[] BackColors = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray",
        "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow", "Gray", "Green", "Magenta", "Red", "White","Yellow" };

        private bool primer_cop = true;
        public PropiedadesConsola()
        {
            InitializeComponent();
        }

        private void PropiedadesConsola_Load(object sender, EventArgs e)
        {
            int idioma = 2;
            HT = hash.MontarTablaTextos(idioma);
            hash.CambiarTextos(this);

            cbx_textcolors.DataSource = TextColors;
            cbx_colorFondo.DataSource = BackColors;

            foreach (XElement node in ArchivoConfig.Descendants("ConfigConsola"))
            {
                cbx_colorFondo.Text = node.Element("ColorFondo").Value;
                cbx_textcolors.Text = node.Element("ColorTexto").Value;
            }

            primer_cop = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_textcolors_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!primer_cop)
            {
                foreach (XElement node in ArchivoConfig.Descendants("ConfigConsola"))
                {
                    node.SetElementValue("ColorTexto", cbx_textcolors.SelectedValue);
                }
                ArchivoConfig.Save(RutaArchivoConfig);
            }
        }

        private void cbx_colorFondo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!primer_cop)
            {
                foreach (XElement node in ArchivoConfig.Descendants("ConfigConsola"))
                {
                    node.SetElementValue("ColorFondo", cbx_colorFondo.SelectedValue);
                }
                ArchivoConfig.Save(RutaArchivoConfig);
            }
        }
    }
}
