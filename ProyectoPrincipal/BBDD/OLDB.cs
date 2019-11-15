using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace BBDD
{
    public class OLDB : Dades
    {
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        OleDbCommandBuilder construct;

        //CREDENCIALS USUARI
        public override DataSet userCredentials(string user)
        {
            string query = "Select * from Users where CodeUser = '" + user + "'";
            return PortarPerConsulta(query);

        }

        //CONNECTAR
        public override void Connectar()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            connection.Open();
            connection.InitializeLifetimeService();

        }

        //PORTAR PER TAULA
        public override DataSet PortarTaula(string nomTaula)
        {
            OleDbCommandBuilder construct;
            string query = "Select * from " + nomTaula;

            try
            {
                Connectar();
                adapter = new OleDbDataAdapter(query, connection);
                construct = new OleDbCommandBuilder(adapter);
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
                adapter = new OleDbDataAdapter(query, connection);
                construct = new OleDbCommandBuilder(adapter);
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
                adapter = new OleDbDataAdapter(query, connection);
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
                adapter = new OleDbDataAdapter(query, connection);
                construct = new OleDbCommandBuilder(adapter);

                if (dataSetActual.HasChanges())
                {
                    adapter.Update(dataSetActual, Taula);
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
                OleDbCommand cmdqry = new OleDbCommand(query, connection);
                return cmdqry.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }

        }
        //MENU
        public override DataSet CarregaMenu(int UserRank)
        {
            string query = "Select * from MenuOptions where RangMin <= " + UserRank;
            return PortarPerConsulta(query);
        }
    }
}
