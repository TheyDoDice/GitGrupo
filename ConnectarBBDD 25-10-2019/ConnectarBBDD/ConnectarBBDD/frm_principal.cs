using System;
using System.Data;
using System.Windows.Forms;
using BBDD;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace ConnectarBBDD
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }
        //Cridem a la llibreria.
        Dades dBUtils = new SQL();

        //Variable consulta
        public string consulta = "select * from Users";

        //Declarem el data set
        public DataSet dataSet;

        private void frm_principal_Load(object sender, EventArgs e)
        {
            dBUtils.Connectar();

            dataSet = dBUtils.PortarPerConsulta(consulta, "users");
            dataGridView1.DataSource = dataSet.Tables["users"];
        }/*
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
