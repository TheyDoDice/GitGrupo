using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SWTextbox
{
    public class SWTextbox1 : System.Windows.Forms.TextBox
    {
        public SWTextbox1()
        {
            InitializeComponent();



        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox1
            // 
            this.Enter += new System.EventHandler(this.SWTextbox1_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox1_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarTipusDada);
            this.ResumeLayout(false);

        }

        public enum tipDades { Numero, Text, Codi, data};

        public tipDades DadaTipus { get; set; }


        public string mensaje { get; set; }
        public string nomCamp { get; set; }
        public bool foranea { get; set; }
        public bool requerit { get; set; }
        public string nomComboBox { get; set; }
        public string controlID { get; set; }



        private void SWTextbox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void SWTextbox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ValidarTipusDada(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Text.Length != 0)
            {

                if (this.DadaTipus == tipDades.Numero)
                {
                    Regex regex = new Regex("^[0-9]+$");
                    if (!regex.IsMatch(this.Text))
                    {
                        //MessageBox.Show("Inserte solo números.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Text = "";
                        e.Cancel = true;
                    }

                }
                else if (this.DadaTipus == tipDades.data)
                {
                    Regex regex = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
                    if (!regex.IsMatch(this.Text))
                    {
                        this.Text = "";
                        e.Cancel = true;
                        //MessageBox.Show("Fehca incorrecta, use el formato DD/MM/YYYY", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.DadaTipus == tipDades.Codi)
                {
                    Regex regex = new Regex("^([A-Z]{4})-([0-9]{3})/([1|3|5|7|9]{1})([A-Z])$");

                    if (!regex.IsMatch(this.Text))
                    {
                        this.Text = "";
                        e.Cancel = true;
                        //MessageBox.Show("Código incorrecto, use el formato ABCD-1234/1A", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (this.Text.Length == 0 && requerit == true)
            {
                e.Cancel = true;
            }

        }

        private void SWTextbox1_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void SWTextbox1_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

    }
    }

