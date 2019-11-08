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

        Dades dBUtils = new SQL();
        public string consulta = "select * from Users";
        public DataSet dataSet;
        public DataTable datable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dBUtils.Connectar();

            dataSet = dBUtils.PortarPerConsulta(consulta);
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
                if (control is GroupBox gb)
                {
                    foreach (var subControl in gb.Controls)
                    {
                        if (subControl is SWTextbox1 swt)
                        {
                            swt.Text = "error";
                            swt.DataBindings.Clear();
                            swt.DataBindings.Add("Text", datable, swt.nomCamp);
                            swt.Validated += (s, ev) => ((SWTextbox1) s).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                            swt.TextChanged += (s, ev) => atualizaLaForanea(swt);
                            atualizaLaForanea(swt);
                        }
                    }
                }
            }
        }

        private void atualizaLaForanea(SWTextbox1 swt)
        {
            if (swt.foranea)
            {
                foreach (var c in this.Controls)
                {
                    if (c is GroupBox gb_2)
                    {
                        foreach (Control item in gb_2.Controls)
                        {
                            if (item is SWCodi swc)
                            {
                                if (swc.Name == swt.controlID)
                                {
                                    swc.ValidaId(swt.Text);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_insertar_usuario_Click(object sender, EventArgs e)
        {
            if (dadesUsuariCorrectes())
            {
                string contra = txt_password.Text;
                Hash encript = new Hash();
                byte[] salt = encript.GenerateSalt();
                byte[] hash = encript.ComputeHash(txt_password.Text, salt);

                DataRow datarow = datable.NewRow();

                foreach (var control in this.Controls)
                {
                    if (control is GroupBox gb)
                    {
                        foreach (var subControl in gb.Controls)
                        {
                            if (subControl is SWTextbox1 swc)
                            {
                                datarow[swc.nomCamp] = swc.Text;

                            }

                        }
                    }
                }
                
                dBUtils.Actualitzar(consulta, "users", dataSet);
            }
            else
            {
                MessageBox.Show("Falten dades.");
            }
            
        }

        private bool dadesUsuariCorrectes()
        {
            return true;
            //return txt_codeUser.Text != "" && txt_userName.Text != "" && txt_photo.Text != "" &&
            //       txt_login.Text != "" && txt_password.Text != "" && swc_UserRank.CodiID != null &&
            //       swc_UserCategory.CodiID != null && swc_UserPlanet.CodiID != null &&
            //       swc_UserSpecie.CodiID != null;
        }
    }
}
