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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dBUtils.Connectar();

            dataSet = dBUtils.PortarPerConsulta(consulta, "users");
            dataGridView1.DataSource = dataSet.Tables["users"];

            comboBox1.DataSource = dataSet.Tables[0];

            comboBox1.DisplayMember = "Username";
            comboBox1.ValueMember = "idUser";
        }

        private void btn_insertar_usuario_Click(object sender, EventArgs e)
        {
            string codeUser = txt_codeUser.Text;
            string userName = txt_userName.Text;
            string loging = txt_login.Text;
            string photo = txt_photo.Text;
            string contra = txt_password.Text;
            
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
                    bool correcte;
                    if (txt_codeUser.Text.Trim() == "")
                    {
                        validador_usuari.SetError(txt_codeUser, "Ha d'escriure un nom d' usuari");
                        correcte = false;
                    }
                    else
                    {
                        validador_usuari.Clear();
                        correcte = true;
                    }

                    if (txt_contrasenya.Text != txtb_repetir_contrasenya.Text)
                    {
                        validador_contrasenya.SetError(txtb_validacio_contrasenya, "Les contrasenyes no coincideixen");
                        correcte = false;
                    }
                    else
                    {
                        validador_contrasenya.Clear();
                        correcte = true;
                    }

                    if( txt_contrasenya.Text == "" || txtb_repetir_contrasenya.Text == "")
                    {
                        validador_contrasenya.SetError(txtb_validacio_contrasenya, "S'ha d'introduïr una contrasenya.");
                    }
                    else
                    {

                    }

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
