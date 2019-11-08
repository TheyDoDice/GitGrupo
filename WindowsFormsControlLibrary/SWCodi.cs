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

namespace WindowsFormsControlLibrary
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
            this.Requerit = false;
        }

        private bool _Requerit;
        private string _FormCS;
        private string _ClasseCs;
        private string _NomID;
        private string _NomCodi;
        private string _NomDesc;
        private string _NomTaula;
        private string _ControlID;
        private string _CodiID;

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

            foreach (var control in myform.Controls)
            {
                if (control is GroupBox gb)
                {
                    foreach (Control subControl in gb.Controls)
                    {
                        if (subControl.Name == ControlID)
                        {
                            subControl.Text = CodiID;
                        }
                    }
                }
            }
        }
        /*
        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        public string FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value; }
        }

        public string ClasseCS
        {   
            get { return _ClasseCs; }
            set { _ClasseCs = value; }
        }

        public string NomID
        {
            get { return _NomID; }
            set { _NomID = value; }
        }

        public string NomCodi
        {
            get { return _NomCodi; }
            set { _NomCodi = value; }
        }

        public string NomDesc
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }

        public string CodiID
        {
            get { return _CodiID; }
            set { _CodiID = value; }
        }
        */
    }
}
