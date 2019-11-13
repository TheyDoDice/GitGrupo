using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using System.Data.OleDb;
using System.Reflection;

namespace CC_Library
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
            this.Requerit = false;
        }

        public bool Requerit { get; set; }
        public string FormCS { get; set; }
        public string ClasseCS { get; set; }
        public string NomID { get; set; }
        public string NomCodi { get; set; }
        public string NomDesc { get; set; }
        public string NomTaula { get; set; }
        public string ControlID { get; set; }
        public string CodiID { get; set; }
        
        public void ValidaCodi(string Codi)
        {
            textBoxCodi.Text = Codi;
            string query = "Select * From " + NomTaula + " Where "+ NomCodi+ " = "+"'"+Codi+"'";
            Dades dades = new SQL();
            DataSet dataSet = dades.PortarPerConsulta(query, NomTaula);
            if(dataSet != null)
            {
                try
                {
                    textBoxDesc.Text = dataSet.Tables[NomTaula].Rows[0][NomDesc].ToString();                    
                    CodiID = dataSet.Tables[NomTaula].Rows[0][NomID].ToString();
                }
                catch
                {

                }

            }
        }
        public void ValidaId(string id)
        {
            string query = "Select * From " + NomTaula + " Where " + NomID + " = '" + id + "'";
            Dades dades = new SQL();
            DataSet dataSet = dades.PortarPerConsulta(query, NomTaula);
            if (dataSet != null)
            {
                try
                {
                    textBoxDesc.Text = dataSet.Tables[NomTaula].Rows[0][NomDesc].ToString();
                    textBoxCodi.Text = dataSet.Tables[NomTaula].Rows[0][NomCodi].ToString();
                    CodiID = id;
                }
                catch
                {

                }

            }
        }
        public void ObreCS()
        {
            string[] args = { NomTaula, "" };
            HelpForm form = new HelpForm(args);
            form.Show();
            form.FormClosed += (se, ev) => ValidaCodi(args[1]);
        }

        private void textBoxCodi_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                ObreCS();
            }

        }

        private void textBoxCodi_TextChanged(object sender, EventArgs e)
        {
            ValidaCodi(textBoxCodi.Text);

            Form myform = this.FindForm();

            foreach (Control control in myform.Controls)
            {
                if (control.Name == ControlID)
                {
                    control.Text = CodiID;
                }
                
            }
        }
    }
}
