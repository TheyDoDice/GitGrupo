using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using CustomSWComboFK;

namespace SWTextbox
{
    public class SWTextbox1 : TextBox
    {
        //Propietat per decidir quin tipus de dada contindra el textbox
        public enum tipDades { Numero, Text, Codi, data };
        public tipDades DadaTipus { get; set; }        
        public string mensaje { get; set; }

        public enum tipControlRef { SWComboBox, SWCodi }
        public tipControlRef TipusControl { get; set; }        
        public string nomCamp { get; set; }        
        public bool foranea { get; set; }        
        public bool requerit { get; set; }        
        public string nomComboBox { get; set; }


        public SWTextbox1()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // SWTextbox1
            // 
            this.MouseEnter += new System.EventHandler(this.SWTextbox1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SWTextbox1_MouseLeave);
            this.ResumeLayout(false);

        }

        private void SWTextbox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void SWTextbox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox1
            // 
            this.TextChanged += new System.EventHandler(this.SWTextbox1_TextChanged);
            this.Validated += new System.EventHandler(this.SWTextbox1_Validated);
            this.ResumeLayout(false);

        }
        private void SWTextbox1_Validated(object sender, EventArgs e)
        {
            Regex comprovador;

            if (this.DadaTipus == tipDades.Numero)
            {
                comprovador = new Regex(@"^[0-9]+$");
                if (!(comprovador.IsMatch(this.Text)))
                {
                    MessageBox.Show("Inserte solo números.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (this.DadaTipus == tipDades.data)
            {
                comprovador = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
                if (!(comprovador.IsMatch(this.Text)))
                {
                    MessageBox.Show("Fehca incorrecta, use el formato DD/MM/YYYY", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (this.DadaTipus == tipDades.Codi)
            {
                comprovador = new Regex(@"^([A-Z]{4})-(\d{4})/(\d{1})([A-Z]{1}$)");
                if (!(comprovador.IsMatch(this.Text)))
                {
                    MessageBox.Show("Código incorrecto, use el formato ABCD-1234/1A", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void SWTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (TipusControl == tipControlRef.SWComboBox)
            {
                UpdateComboBox();
            }
        }

        private void UpdateComboBox()
        {
            Form myForm = this.FindForm();

            if (myForm != null)
            {
                foreach (Control ctr in myForm.Controls)
                {
                    if (ctr.GetType() == typeof(GroupBox))
                    {
                        foreach (Control ctr1 in ctr.Controls)
                        {
                            if (ctr1.GetType() == typeof(SWComboFK))
                            {
                                SWComboFK cc = (SWComboFK)ctr1;
                                cc.SelectedValue = Int32.Parse(this.Text);
                                cc.ConnectDatabase();
                            }
                        }
                    }
                    else if (ctr.GetType() == typeof(SWComboFK))
                    {
                        SWComboFK cb = (SWComboFK)ctr;
                        cb.SelectedValue = Int32.Parse(this.Text);
                        cb.ConnectDatabase();
                    }
                }
            }
        }
    }
}
