using System;
using System.Data;
using System.Windows.Forms;
using BBDD;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ConnectarBBDD
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        //Cridem a la llibreria.
        Dades bbdd = new SQL();

        //Variable consulta
        public string consulta = "select * from Users";

        //Declarem el data set
        public DataSet dadesConsulta;

        private void bttn_mostrardades_sql_Click(object sender, EventArgs e)
        {
            //Fer la select de la taula usuaris
            dadesConsulta = bbdd.PortarPerConsulta(consulta, "prova");

            //Mostrar les dades en un data grid view
            dataGridView1.DataSource = dadesConsulta.Tables["prova"];

        }

        private void btn_insertar_usuario_Click(object sender, EventArgs e)
        {
            //Declarem les variables
            bool conectat;
            bool insert;
            bool check_credencials;

           // check_credencials = comprobar_credenciales();
           /*// if (check_credencials)
            {
             /*   //Obrim la connexió.
                dBUtils.ObrirConnexioSQL();

                //Comprobar si s'ha pogut  connectar
                conectat = dBUtils.ComprovarConnexioSQL();
                if (conectat)
                {
                    //Insertar l' usuari
                    insert = dBUtils.InsertarUsuariSQL(txtb_nom_usuari.Text.Trim());
                    if (insert)
                    {
                        MessageBox.Show("Usuari insertat correctament.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualitzar_taula();

                    }
                    else
                    {
                        MessageBox.Show("No s'ha pogut insertar l' usuari.", "Error de inserció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No s'ha pogut establir la connexió amb la base de dades.", "Error de connexió", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Tanquem la connexió
                dBUtils.TancarConnexioSQL();
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            //Esborrar les files seleccionades
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
                MessageBox.Show("Usuari borrat correctament.", "Error de inserció", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Actualitzem la taula
            actualitzar_taula();

            //Tanquem la connexió
            dBUtils.TancarConnexioSQL();
        }*/

        /*===============================================================================================
	        Funcion Actualizar (antiguo botón)
        =================================================================================================*/
        /*private void actualitzar_taula()
        {
            //Declarar variables
            bool conectat;
            bool actualitzar;

            //Obrim la connexió.
            dBUtils.ObrirConnexioSQL();

            //Comprovem que la connexió está funcionant. 
            conectat = dBUtils.ComprovarConnexioSQL();
            if (conectat)
            {
                //Actualitzem la base de dades del servidor. 
                actualitzar = dBUtils.ActualitzarTaulaSQL(consulta, "prova", dadesConsulta);
                if (actualitzar)
                {
                    MessageBox.Show("Taula actualitzada correctament", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No s' ha pogut actualitzar la taula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No s' ha pogut establir una connexió amb la base de dades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        /*===============================================================================================
            Funcion Comprovar credenciales
        =================================================================================================*/
       /* private bool comprobar_credenciales()
        {
            bool usuari_correcte;
            bool contrasenya_correcte;
            bool pot_insertar = false;

            if (txtb_nom_usuari.Text.Trim() == "")
            {
                validador_usuari.SetError(txtb_nom_usuari, "Ha d'escriure un nom d' usuari");
                usuari_correcte = false;
            }
            else
            {
                validador_usuari.Clear();
                usuari_correcte = true;
            }

            if (txtb_contrasenya.Text != txtb_repetir_contrasenya.Text)
            {
                validador_contrasenya_igual.SetError(txtb_repetir_contrasenya, "Les contrasenyes no coincideixen");
                contrasenya_correcte = false;
            }
            else
            {
                validador_contrasenya_igual.Clear();
                contrasenya_correcte = true;
            }

            if (txtb_contrasenya.Text == "" || txtb_repetir_contrasenya.Text == "")
            {
                validador_contrasenya_blanc.SetError(txtb_repetir_contrasenya, "S'ha d'introduïr una contrasenya.");
                contrasenya_correcte = false;
            }
            else
            {
                validador_contrasenya_blanc.Clear();
            }

            if (usuari_correcte && contrasenya_correcte)
            {
                pot_insertar = true;
            }

            return pot_insertar;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Esteu segur que voleu sortir?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (pregunta == DialogResult.No)
            {
            }*/
        }
    }
}
