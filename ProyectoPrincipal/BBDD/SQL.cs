using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BBDD
{
    public class SQL : Dades
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder construct;

        //CONNECTIONSTRING
       /* public override string connectionString
        {
            get
            {
                return "Data Source=theydodice.database.windows.net;Initial Catalog=securecore;Persist Security Info=True;User ID=theydodice;Password=123456aA";
            }
        }*/

        //CREDENCIALS USUARI
        public override DataSet userCredentials(string user)
        {
            string query = "Select * from Users where CodeUser = '" + user + "'";
            return PortarPerConsulta(query);

        }

        //CONNECTAR
        public override void Connectar()
        {
            connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            connection.Open();
            connection.InitializeLifetimeService();

        }

        //PORTAR PER TAULA
        public override DataSet PortarTaula(string nomTaula)
        {
            SqlCommandBuilder construct;
            string query = "Select * from " + nomTaula;

            try
            {
                Connectar();
                adapter = new SqlDataAdapter(query, connection);
                construct = new SqlCommandBuilder(adapter);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }
            catch
            {
                dataSet = null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return dataSet;
        }

        //PORTAR PER CONSULTA
        public override DataSet PortarPerConsulta(string query)
        {
            try
            {
                Connectar();
                adapter = new SqlDataAdapter(query, connection);
                construct = new SqlCommandBuilder(adapter);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }
            catch
            {
                dataSet = null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return dataSet;
        }

        public override DataSet PortarPerConsulta(string query, string name)
        {
            try
            {
                Connectar();
                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, name);
            }
            catch
            {
                dataSet = null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return dataSet;
        }

        //ACTUALITZAR
        public override bool Actualitzar(string query, string Taula, DataSet dataSetActual)
        {
            bool correcte = true;
            try
            {
                Connectar();
                adapter = new SqlDataAdapter(query, connection);
                construct = new SqlCommandBuilder(adapter);

                if (dataSetActual.HasChanges())
                {
                    adapter.Update(dataSetActual.Tables[0]);
                }
            }
            catch
            {
                correcte = false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return correcte;
        }

        //EXECUTAR
        public override int Executa(string query)
        {
            try
            {
                Connectar();
                SqlCommand cmdqry = new SqlCommand(query, connection);
                return cmdqry.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }

        }
    }
}
