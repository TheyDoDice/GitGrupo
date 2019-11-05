using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;

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
            dataGridView1.DataSource = dataSet.Tables[0];
            datable = dataSet.Tables[0];

            comboBox1.DataSource = datable;
            comboBox1.DisplayMember = "Username";
            comboBox1.ValueMember = "idUser";


        }

        private void btn_insertar_usuario_Click(object sender, EventArgs e)
        {

            string contra = txt_password.Text;

            DataRow datarow = datable.NewRow();

            datarow["idUser"] = 39;
            datarow["CodeUser"] = txt_codeUser.Text;
            datarow["UserName"] = txt_userName.Text;
            datarow["Photo"] = txt_photo.Text; ;
            datarow["Login"] = txt_login.Text;
            datarow["Password"] = txt_password.Text;
            datarow["Salt"] = txt_password.Text;

            datable.Rows.Add(datarow);

            if (dBUtils.Actualitzar(consulta, "users", dataSet))
            {
                MessageBox.Show("actualizado");
            }else{
                MessageBox.Show("no acualizado");
            }
            
        }

        /*
                private void btn_actualitzar_taula_Click(object sender, EventArgs e)
                {
                    bool actualitzar;

                    actualitzar = dBUtils.Actualitzar(consulta, "prova", dadesConsulta);
                    if (actualitzar)
                    {
                        MessageBox.Show("Taula actualitzada correctament", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No s' ha pogut actualitzar la taula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                private void btn_insertar_usuario_Click(object sender, EventArgs e)
                {
                    bool insert;

                    if (correcte)
                    {
                        insert = dBUtils.InsertarUsuariSQL(txt_codeUser.Text.Trim());
                        if (insert)
                        {
                            MessageBox.Show("Usuari insertat correctament.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Update();
                            dataGridView1.Refresh();

                        }
                        else
                        {
                            MessageBox.Show("No s'ha pogut insertar l' usuari.", "Error de inserció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


        ;        }
        
                private void btn_delete_user_Click(object sender, EventArgs e)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Usuari borrat correctament.", "Error de inserció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }*/
    }
}
