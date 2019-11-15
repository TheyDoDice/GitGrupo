using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD
{
    public abstract class Dades
    {

        protected DataSet dataSet;

        //CONNECTIONSTRING
        // public abstract string connectionString { get; }

        //CREDENCIALS USUARI
        public abstract DataSet userCredentials(string user);

        //CONNECTAR
        public abstract void Connectar();

        //PORTAR PER TAULA
        public abstract DataSet PortarTaula(string nomTaula);

        //PORTAR PER CONSULTA
        public abstract DataSet PortarPerConsulta(string query);
        public abstract DataSet PortarPerConsulta(string query, string name);

        //ACTUALITZAR
        public abstract bool Actualitzar(string query, string Taula, DataSet dataSetActual);

        //EXECUTAR
        public abstract int Executa(string query);

        //CARREGAR OPCIONS DE MENU
        public abstract DataSet CarregaMenu(int UserRank);
    }
}
