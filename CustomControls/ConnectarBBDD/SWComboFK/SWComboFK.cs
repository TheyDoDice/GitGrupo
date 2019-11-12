using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BBDD;

namespace CustomSWComboFK
{
    public partial class SWComboFK : System.Windows.Forms.ComboBox
    {
        private string _ControlID;
        private string _nomtaula;
        private bool ple = false;

        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }

        public string NomTaula
        {
            get { return _nomtaula; }
            set { _nomtaula = value; }
        }

        private string _ValorId;

        public string ValorId
        {
            get { return _ValorId; }
            set { _ValorId = value;
                this.ValueMember = value;
                }
        }

        public SWComboFK()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {  
            this.SuspendLayout();
            // 
            // SWComboFK
            // 
            this.SelectedValueChanged += new System.EventHandler(this.PassaValor);
            this.Enter += new System.EventHandler(this.SWComboFK_Enter);
            this.ResumeLayout(false);
        }

        private void PassaValor(object sender, EventArgs e)
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
                            if (ctr1.Name == _ControlID)
                            {
                                ctr1.Text = this.SelectedValue.ToString();
                                //ctr1.Text = this.SelectedIndex.ToString();

                            }
                        }
                    }
                    else if (ctr.Name == _ControlID)
                    {
                        ctr.Text = this.SelectedValue.ToString();
                        //ctr.Text = this.SelectedIndex.ToString();
                    }
                }
            }
        }

        public void ConnectDatabase()
        {
            if (ple == false)
            {
                string query;
                query = "SELECT * From " + NomTaula;
                string.Concat(NomTaula);

                DataSet dades;
                SQL BBDD = new SQL();

                dades = BBDD.PortarPerConsulta(query, "Users");

                this.DataSource = dades.Tables["Users"];
                ple = true;

            }
        }
       
        private void SWComboFK_Enter(object sender, EventArgs e)
        {
            ConnectDatabase();            
        }
    }
}
