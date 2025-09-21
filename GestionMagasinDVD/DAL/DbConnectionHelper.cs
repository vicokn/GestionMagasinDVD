using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasinDVD.DAL
{
    internal class DbConnectionHelper
    {
        // Chaîne de connexion à ta base SQL Server
        public static string ConnectionString =
            @"Data Source=LAPTOP-MVGMHCGR\SQLEXPRESS;
          Initial Catalog=BDMagasinDVD;
          Integrated Security=True;
          Encrypt=False";

        // Méthode utilitaire pour obtenir une connexion ouverte
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
