using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            this.Validated += new System.EventHandler(this.SWTextbox1_Validated);
            this.ResumeLayout(false);


        }

        private void SWTextbox1_Validated(object sender, EventArgs e)
        {
            if (this.Text.All(char.IsDigit))
            {
                mensaje = "soy una numero?";
                if (this.DadaTipus != tipDades.Numero)
                {
                    //this.Text = "";
                }
            }
            else if (this.Text.ToUpper() != this.Text.ToLower())
            {
                if (this.Text.Any(char.IsDigit))
                {
                    mensaje = "soy una codigo?";
                    if (this.DadaTipus != tipDades.Codi)
                    {
                        //this.Text = "";
                    }
                }
                else
                {
                    mensaje = "soy una texto?";
                    if (this.DadaTipus != tipDades.Text)
                    {
                        //this.Text = "";
                    }
                }
               
            }
        }
    }
}
