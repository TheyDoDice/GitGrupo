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
        public string NomClase { get; set; }
        public string NomFormulari { get; set; }
        public string PanelForm { get; set; }

        public SWMenuItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(@NomDLL);

            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(NomClase + "." + NomFormulari);

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
