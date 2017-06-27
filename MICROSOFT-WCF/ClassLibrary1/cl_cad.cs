using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace data
{
    class cl_cad
    {
        private string cnx;                             //Chemin d'accès

        private SqlDataAdapter oSqlDataAdapter;         //Objet lien entre appli et bdd
        private SqlConnection oConnection;              //Objet connexion assure la co à la bdd
        private SqlCommand oCommand;                    //Objet commande execute la requete sql
        private DataSet oDataSet;                       //Objet dataset non connecté
        public cl_cad()
        {
            oCommand = null;
            oSqlDataAdapter = null;
            cnx = @"Data Source=MSI;Initial Catalog=WCF;Integrated Security=True";
            oConnection = new SqlConnection(cnx);
            oDataSet = new DataSet();
        }

        public void ActionRows(string rq)
        {
            oCommand = new SqlCommand(rq, oConnection);
            oSqlDataAdapter = new SqlDataAdapter(oCommand);
            oSqlDataAdapter.Fill(oDataSet);
        }

        public DataSet getRows(string rq, string tab)
        {
            oDataSet.Clear();
            oCommand = new SqlCommand(rq, oConnection);
            oSqlDataAdapter = new SqlDataAdapter(oCommand);
            oSqlDataAdapter.Fill(oDataSet, tab);
            return oDataSet;
        }
    }
}
