using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
            this.Requerit = false;
        }

        public SWCodi(string form, string classe, string taula, bool requerit) : this()
        {
            this.FormCS = form;
            this.ClasseCS = classe;
            this.NomTaula = taula;
            this.Requerit = requerit;
        }

        private bool _Requerit;
        private string _FormCS;
        private string _ClasseCs;
        private string _NomID;
        private string _NomCodi;
        private string _NomDesc;
        private string _NomTaula;
        private string _ControlID;

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

        public void ValidaCodi()
        {

        }

        public void ObreCS()
        {

        }

        private void textBoxCodi_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
            else if(e.KeyCode == Keys.F2)
            {
                //Abrir formulario ClasseCs
            }
        }
    }
}
