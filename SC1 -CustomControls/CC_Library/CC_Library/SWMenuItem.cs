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

        public string Texto
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
        public string Picture { get; set; }



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

        private void ObrirFrom()
        {
            try
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
                        control.Controls.Clear();
                        newForm.TopLevel = false;
                        newForm.Dock = DockStyle.Fill;
                        newForm.AutoScroll = true;
                        ((Panel)control).Controls.Add(newForm);
                        newForm.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dades incorrectes, revisa el paràmetres del menuItem.\n\n En cas de no poder accedir al manteniment de la taula demana ajuda a un rank superior.");
            }
            
        }

        private void SWMenuItem_Load(object sender, EventArgs e)
        {
            this.Click += (s, ev) => { ObrirFrom(); };
            label.Click += (s, ev) => { ObrirFrom(); };
            pictureBox.Click += (s, ev) => { ObrirFrom(); };

            this.MouseEnter += (se, ev) => this.BackColor = Color.DimGray;
            this.MouseLeave += (se, ev) => this.BackColor = Color.Transparent;
            label.MouseEnter += (se, ev) => this.BackColor = Color.DimGray;
            label.MouseLeave += (se, ev) => this.BackColor = Color.Transparent;
            pictureBox.MouseEnter += (se, ev) => this.BackColor = Color.DimGray;
            pictureBox.MouseLeave += (se, ev) => this.BackColor = Color.Transparent;

            try
            {
                pictureBox.ImageLocation = Application.StartupPath + "\\Img\\" + Picture;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
