using System;
using System.Windows.Forms;
using Hashcodes;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HashCodes hash = new HashCodes("G:\\Sistema Hashcodes\\Hashcodes\\hashcodes.h", "G:\\Sistema Hashcodes\\Hashcodes\\ProgramStrings.txt", "G:\\Sistema Hashcodes\\Hashcodes\\ProgramColors.txt");
        private void Form1_Load(object sender, EventArgs e)
        {
            int idioma = 2;
            hash.MontarTablaTextos(idioma, "Section_Test");
            hash.CambiarTextos(this);
            hash.MontarTablaColores("Section_Test");
            hash.CambiarColores(1, this);
        }

        private void btn_showHashcodeValue_Click(object sender, EventArgs e)
        {
            string valorNumerico;
            string myValue = Microsoft.VisualBasic.Interaction.InputBox("Introduce un Hashcode para saber su identificador:", "Mostrar identificador de un Hashcode");

            valorNumerico = hash.ObtenerIdentificadorHashcode(myValue);
            MessageBox.Show("El identificador del Hashcode: " + myValue + " es: " + valorNumerico);
        }

        private void btn_showcontent_Click(object sender, EventArgs e)
        {
            string valor;
            string myValue = Microsoft.VisualBasic.Interaction.InputBox("Introduce un Hashcode para saber su contenido: ", "Mostrar contenido de un Hashcode");

            //valor = hash.ObtenerValorHashcode(1,myValue);
           // MessageBox.Show("El valor del Hashcode: " + myValue + " es: " + valor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new form2();
            frm.Show();
        }
    }
}
