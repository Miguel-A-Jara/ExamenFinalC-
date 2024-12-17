using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConexionesWF1
{
    internal class DbManager
    {

        private static SqlConnection dbConnection = null;
        public static SqlConnection DbConnection
        {
            get { 
                if(dbConnection == null)
                {
                    openConnection();
                }
                return dbConnection;
            }
        }


        public static void openConnection()
        {
            string conectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            dbConnection = new SqlConnection(conectionString);
            dbConnection.Open();
        }

        public static void closeConnection()
        {
            dbConnection.Close();
        }
    }
}
