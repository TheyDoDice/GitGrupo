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
        private string _nomCamp;


     


        //Propietat per decidir quin tipus de dada contindra el textbox
        public enum tipDades { Numero, Text, Codi, data};


        public tipDades DadaTipus { get; set; }

        /*private tipDades _dadaTipus;
        
        public tipDades DadaTipus
        {
            get { return _dadaTipus; }
            set { _dadaTipus = value; }
        }*/
        
            private string _mensaje;
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        

        public string nomCamp
        {
            get { return _nomCamp; }
            set { _nomCamp = value; }
        }

        private bool _foranea;

        public bool foranea
        {
            get { return _foranea; }
            set { _foranea = value; }
        }


        private string _nomComboBox;

        public string nomComboBox
        {
            get { return _nomComboBox; }
            set { _nomComboBox = value; }
        }

      

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
            this.Leave += new System.EventHandler(this.SWTextbox1_Leave);
            this.MouseLeave += new System.EventHandler(this.SWTextbox1_MouseLeave_1);
            this.Validated += new System.EventHandler(this.SWTextbox1_Validated);
            this.ResumeLayout(false);

        }

        private void SWTextbox1_Validated(object sender, EventArgs e)
        {
            //if (!this.Text.All(char.IsDigit))
            //{

        
            //}
            //else if (this.Text.ToUpper() != this.Text.ToLower())
            //{
              //  if (this.Text.Any(char.IsDigit))
                //{

                    /*if (this.DadaTipus != tipDades.Codi)
                    {
                        this.Text = "Es necessitan un codi";
                    }
                //}
                //else
                //{

                    if (this.DadaTipus != tipDades.Text)
                    {
                        this.Text = "Es necessita un text";
                    }*/
               //}
            //}
          
        }

        private void SWTextbox1_MouseLeave_1(object sender, EventArgs e)
        {
           

                
            }

        private void SWTextbox1_Leave(object sender, EventArgs e)
        {
            if (this.Text != "")
            {

                if (this.DadaTipus == tipDades.Numero)
                {
                    Regex regex = new Regex("^[0-9]+$");
                    if (!regex.IsMatch(this.Text))
                    {
                        MessageBox.Show("Inserte solo números.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (this.DadaTipus == tipDades.data)
                {
                    Regex regex = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
                    if (!regex.IsMatch(this.Text))
                    {
                        MessageBox.Show("Fehca incorrecta, use el formato DD/MM/YYYY", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.DadaTipus == tipDades.Codi)
                {
                    Regex regex = new Regex("^([A-Z]{4})-([0-9]{3})/([1|3|5|7|9]{1})([A-Z])$");

                    if (!regex.IsMatch(this.Text))
                    {
                        MessageBox.Show("Código incorrecto, use el formato ABCD-1234/1A", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    }

