using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasinDVD.DAL
{
    public class ClientRepository
    {
        public DataTable GetClients()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT IdClient, Nom, Prenom, Email, Telephone, Adresse, CotisationEnOrdre, DateInscription 
                               FROM Client";
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    var t = new DataTable();
                    da.Fill(t);
                    return t;
                }
            }
        }
        public DataTable GetEmpruntsEnCoursDuClient(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT D.Titre AS [Titre DVD],
                   E.DateEmprunt,
                   E.DateRetourPrevue
            FROM Emprunt E
            JOIN DVD D ON E.IdDVD = D.IdDVD
            WHERE E.IdClient = @id
              AND E.DateRetourEffective IS NULL";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idClient);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable GetClientById(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT IdClient, Nom, Prenom, Email, Telephone, Adresse, CotisationEnOrdre, DateInscription
                       FROM Client
                       WHERE IdClient = @id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idClient);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var t = new DataTable();
                        da.Fill(t);
                        return t;
                    }
                }
            }
        }


        public DataTable RechercherClients(string recherche)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT IdClient, Nom, Prenom, Email, Telephone, Adresse, CotisationEnOrdre, DateInscription
                               FROM Client
                               WHERE Nom LIKE @rech OR Prenom LIKE @rech OR Email LIKE @rech 
                                     OR Telephone LIKE @rech OR Adresse LIKE @rech";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rech", "%" + recherche + "%");
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var t = new DataTable();
                        da.Fill(t);
                        return t;
                    }
                }
            }
        }

        public void AjouterClient(string nom, string prenom, string email, string telephone, string adresse, bool cotisationEnOrdre)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"INSERT INTO Client (Nom, Prenom, Email, Telephone, Adresse, CotisationEnOrdre, DateInscription)
                               VALUES (@nom, @prenom, @mail, @tel, @adr, @cot, GETDATE())";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@tel", (object)telephone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@adr", (object)adresse ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cot", cotisationEnOrdre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ModifierClient(int idClient, string nom, string prenom, string email, string telephone, string adresse, bool cotisationEnOrdre)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"UPDATE Client
                               SET Nom = @nom, Prenom = @prenom, Email = @mail, Telephone = @tel, Adresse = @adr, CotisationEnOrdre = @cot
                               WHERE IdClient = @id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idClient);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@tel", (object)telephone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@adr", (object)adresse ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cot", cotisationEnOrdre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

      
        public void SupprimerUnClientEtSesLiens(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                // 1. Supprimer les rappels liés aux emprunts du client
                string sqlRappel = @"
            DELETE FROM Rappel
            WHERE idEmprunt IN (SELECT idEmprunt FROM Emprunt WHERE idClient = @id)";
                using (var cmdRappel = new SqlCommand(sqlRappel, conn))
                {
                    cmdRappel.Parameters.AddWithValue("@id", idClient);
                    cmdRappel.ExecuteNonQuery();
                }

                // 2. Supprimer les emprunts du client
                string sqlEmprunt = "DELETE FROM Emprunt WHERE idClient = @id";
                using (var cmdEmprunt = new SqlCommand(sqlEmprunt, conn))
                {
                    cmdEmprunt.Parameters.AddWithValue("@id", idClient);
                    cmdEmprunt.ExecuteNonQuery();
                }

                // 3. Supprimer le client
                string sqlClient = "DELETE FROM Client WHERE idClient = @id";
                using (var cmdClient = new SqlCommand(sqlClient, conn))
                {
                    cmdClient.Parameters.AddWithValue("@id", idClient);
                    cmdClient.ExecuteNonQuery();
                }
            }
        }



    }
}
