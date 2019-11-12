using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using Encriptar;
using WindowsFormsControlLibrary;
using SWTextbox;

namespace CrearUsuari
{
    public partial class Form1 : Form
    {

        Dades bbdd = new SQL();
        public string consulta = "select * from Users";
        public DataSet dataSet;
        public DataTable datable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bbdd.Connectar();

            dataSet = bbdd.PortarPerConsulta(consulta);
            datable = dataSet.Tables[0];
            dataGridView1.DataSource = datable;
            
            Regex rg = new Regex("^id");
            
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (rg.Match(item.Name).Success)
                {
                    dataGridView1.Columns[item.Name].Visible = false;
                }
            }

            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
                {
                    swt.DataBindings.Clear();
                    swt.DataBindings.Add("Text", datable, swt.nomCamp);
                    swt.Validated += (s, ev) => ((SWTextbox1) s).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                    swt.TextChanged += (s, ev) => atualizaLaForanea(swt);
                    atualizaLaForanea(swt);
                } 
            }
        }

        private void atualizaLaForanea(SWTextbox1 swt)
        {
            if (swt.foranea)
            {
                foreach (var c in this.Controls)
                {
                    if (c is SWCodi swc)
                    {
                        if (swc.Name == swt.controlID)
                        {
                            swc.ValidaId(swt.Text);
                        }
                    }   
                    
                }
            }
        }

        private void btn_insertar_usuario_Click(object sender, EventArgs e)
        {
            if (dadesUsuariCorrectes())
            {
                DataRow datarow = datable.NewRow();

                foreach (var control in this.Controls)
                {
                    if (control is SWTextbox1 swc)
                    {
                        if (swc.nomCamp == "Password")
                        {
                            string contra = swc.Text;
                            Hash encript = new Hash();
                            byte[] byteArraySalt = encript.GenerateSalt();
                            byte[] byteArrayhash = encript.ComputeHash(contra, byteArraySalt);
                            datarow["Salt"] = Convert.ToBase64String(byteArraySalt);
                            datarow[swc.nomCamp] = Convert.ToBase64String(byteArrayhash);
                        } else
                        {
                            datarow[swc.nomCamp] = swc.Text;
                        }
                    }    
                }
                datable.Rows.Add(datarow);
                bbdd.Actualitzar(consulta, "users", dataSet);
            }
            else
            {
                MessageBox.Show("Falten dades.");
            }
            
        }

        private bool dadesUsuariCorrectes()
        {
            bool res = true;
            foreach (var control in this.Controls)
            {
                if (control is SWTextbox1 swt)
                {
                    res = swt.Text != "";
                }
            }
            return res;
        }
    }
}
