using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CC_Library
{
    public partial class SWMenuItem : UserControl
    {
        public string NomDLL { get; set; }
        public string NameSpace { get; set; }
        public string NomClasse { get; set; }

        public SWMenuItem()
        {
            InitializeComponent();
        }

        private string ComprobarNom(string NomDLL)
        {
            int str_length = NomDLL.Trim().Length;

            if (str_length > 4)
            {
                string nom = NomDLL.Trim().Substring(str_length - 4, 4);
                if (!(nom == ".dll"))
                {
                    NomDLL = NomDLL + ".dll";
                }
            }

            return NomDLL;
        }

        private void SWMenuItem_Click(object sender, EventArgs e)
        {
            string NomArxiu = ComprobarNom(NomDLL);
            Assembly ensamblat = Assembly.LoadFrom(NomArxiu);

            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(NameSpace + "." + NomClasse);

            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }
    }
}
