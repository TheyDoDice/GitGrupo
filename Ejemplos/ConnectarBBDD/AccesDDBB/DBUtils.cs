using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace AccesDDBB
{
    public class DBUtils
    {
        public static string connectSQL = "Data Source=theydodice.database.windows.net;Initial Catalog=securecore;User ID=theydodice;Password=123456aA";
        public static string connectionOleDB = "";
        public SqlConnection connexioSql = new SqlConnection(connectSQL);
        public OleDbConnection connexioOleDB = new OleDbConnection(connectionOleDB);

        //Obrir connexio OleDB
        public void ObrirConnexioOleDB()
        {
            try
            {
                connexioOleDB.Open();
            }
            catch
            {
                Console.WriteLine("No s' ha pogut connectar a la base de dades.");
            }
        }

        //Obrir connexio SQL
        public void ObrirConnexioSQL()
        {
             try
             {
                connexioSql.Open();
             }
             catch
             {
                 Console.WriteLine("No s' ha pogut connectar a la base de dades.");
             }
        }


        //Comprovar connexio OleDB
        public bool ComprovarConnexioOleDb()
        {
            bool connectat = false;
            if (connexioOleDB.State == ConnectionState.Open)
            {
                connectat = true;
            }

            return connectat;
        }

        //Comprovar connexio SQL
        public bool ComprovarConnexioSQL()
        {
            bool connectat = false;
            if (connexioSql.State == ConnectionState.Open)
            {
                connectat = true;
            }

            return connectat;
        }

        //Consulta OleDB
        public DataSet ConsultaOleDB(string consulta, string NomTaula)
        {
            DataSet dtsDades;
            OleDbDataAdapter dtaDades;
            System.Data.OleDb.OleDbCommandBuilder construct;
            try
            {
                ObrirConnexioOleDB();
                dtaDades = new OleDbDataAdapter(consulta, connexioOleDB);
                construct = new OleDbCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dtaDades.Fill(dtsDades, NomTaula);
                TancarConnexioOleDB();
            }
            catch (Exception)
            {
                dtsDades = null;
            }

            return dtsDades;
        }

        //Insert SQL
        public bool InsertarUsuariSQL(string name)
        {
            bool check_insertat = true;
            string insert = "INSERT INTO Users(CodeUser, UserName, Login, Password, idUserRank, idUserCategory, Photo, idPlanet, idSpecie, Salt)" 
                            + "VALUES ('PRUEBA', '" + name + "', '2', 'AA6chstdhiLHs3/u6b2uTjP0lmW/StFA', 1, 1, 'Adri.jpg', 1, 1, 'KbljdrQ0PpRdG59FHp7nTPou9ATlrymK');";
            try
            {
                ObrirConnexioSQL();
                SqlCommand ferInsert = new SqlCommand(insert, connexioSql);
                ferInsert.ExecuteNonQuery();
                TancarConnexioSQL();
            }
            catch (SqlException)
            {
                check_insertat = false;
            }

            return check_insertat;
        }


        //Consulta SQL
        public DataSet ConsultaSQL (string consulta, string NomTaula)
        {
            DataSet dtsDades;
            SqlDataAdapter dtaDades;
            SqlCommandBuilder construct;

            try
            {
                ObrirConnexioSQL();
                dtaDades = new SqlDataAdapter(consulta, connexioSql);
                construct = new SqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dtaDades.Fill(dtsDades, NomTaula);
                TancarConnexioSQL();
            }
            catch (SqlException)
            {
                dtsDades = null;
            }

            return dtsDades;
        }

        //Actualitzar DataGridView SQL
        public bool ActualitzarTaulaSQL(string query, string Taula, DataSet dtsAct)
        {
            bool correcte = true;
            SqlDataAdapter dtaDepart;
            SqlCommandBuilder construct;

            try
            {
                ObrirConnexioSQL();
                dtaDepart = new SqlDataAdapter(query, connexioSql);
                construct = new SqlCommandBuilder(dtaDepart);

                if (dtsAct.HasChanges())
                    dtaDepart.Update(dtsAct, Taula);
                TancarConnexioSQL();
            }
            catch (SqlException)
            {
                correcte = false;
            }

            return correcte;
        }

        //Actualizar DataGridView OLEDB
        public bool ActualitzarTaulaOleDB(string query, string Taula, DataSet dtsAct)
        {
            bool correcte = true;

            System.Data.OleDb.OleDbDataAdapter dtaDepart;
            System.Data.OleDb.OleDbCommandBuilder construct;
            try
            {
                ObrirConnexioOleDB();

                dtaDepart = new OleDbDataAdapter(query, connexioOleDB);
                construct = new OleDbCommandBuilder(dtaDepart);

                if ((dtsAct.HasChanges()))
                    dtaDepart.Update(dtsAct, Taula);
                TancarConnexioOleDB();
            }
            catch (OleDbException)
            {
                correcte = false;
            }

            return correcte;
        }
        //Tancar Connexio SQL
        public void TancarConnexioSQL()
        {
            connexioSql.Close();
        }

        //Tancar Connexio OleDB
        public void TancarConnexioOleDB()
        {
            connexioOleDB.Close();

        }

    }
}
