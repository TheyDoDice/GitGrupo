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
            

            dataGridView1.Columns["idUser"].Visible = false;
            
            Regex rg = new Regex("^id");
            
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (rg.Match(item.Name).Success)
                {
                    dataGridView1.Columns[item.Name].Visible = false;
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
            
                datarow["CodeUser"] = txt_codeUser.Text;
                datarow["UserName"] = txt_userName.Text;
                datarow["Photo"]    = txt_photo.Text; ;
                datarow["Login"]    = txt_login.Text;
                datarow["Password"] = Convert.ToBase64String(hash);
                datarow["Salt"]     = Convert.ToBase64String(salt);
                datarow["idUserRank"] = swc_UserRank.CodiID;
                datarow["idUserCategory"] = swc_UserCategory.CodiID;
                datarow["idPlanet"] = swc_UserPlanet.CodiID;
                datarow["idSpecie"] = swc_UserSpecie.CodiID;
                
                datable.Rows.Add(datarow);
                dBUtils.Actualitzar(consulta, "users", dataSet);
            }
            else
            {
                MessageBox.Show("Falten dades.");
            }
            
        }

        private bool dadesUsuariCorrectes()
        {
            return txt_codeUser.Text != "" && txt_userName.Text != "" && txt_photo.Text != "" &&
                   txt_login.Text != "" && txt_password.Text != "" && swc_UserRank.CodiID != null &&
                   swc_UserCategory.CodiID != null && swc_UserPlanet.CodiID != null &&
                   swc_UserSpecie.CodiID != null;
        }
    }
}
