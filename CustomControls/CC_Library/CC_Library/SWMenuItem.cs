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
        public string PanelForm { get; set; }

        public SWMenuItem()
        {
            InitializeComponent();
        }

        private string ComprobarNom(string NomDLL)
        {
            int str_length = NomDLL.Trim().Length;

            if (str_length > 4)
            {
                if (NomDLL.Substring(str_length - 4) != ".dll")
                {
                    NomDLL += ".dll";
                }
            }

            return NomDLL;
        }

        private void SWMenuItem_Click(object sender, EventArgs e)
        {
            string NouNomDll = ComprobarNom(NomDLL);
            Assembly ensamblat = Assembly.LoadFrom(NouNomDll);

            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(NameSpace + "." + NomClasse);

            dllBD = Activator.CreateInstance(tipus);

            Form newForm = ((Form)dllBD);

            Form myform = this.FindForm();

            foreach (Control control in myform.Controls)
            {
                if (control.Name == PanelForm)
                {
                    newForm.TopLevel = false;
                    newForm.Dock = DockStyle.Fill;
                    newForm.AutoScroll = true;
                    ((Panel)control).Controls.Add(newForm);
                    newForm.Show();
                }
            }
        }
    }
}
