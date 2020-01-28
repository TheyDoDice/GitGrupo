using System;
using System.Windows.Forms;
using Hashcodes;


namespace Demo
{
    public partial class form2 : Form
    {

        HashCodes hash2 = new HashCodes("G:\\Sistema Hashcodes\\Hashcodes\\hashcodes.h", "G:\\Sistema Hashcodes\\Hashcodes\\ProgramStrings.txt", "G:\\Sistema Hashcodes\\Hashcodes\\ProgramColors.txt");

        public form2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {
            hash2.MontarTablaTextos(2, "Section_Form2");
            hash2.CambiarTextos(this);
            hash2.MontarTablaColores("Section_Generic");
            hash2.CambiarColores(1, this);
        }
    }
}
