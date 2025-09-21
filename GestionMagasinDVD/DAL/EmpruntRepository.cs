using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasinDVD.DAL
{
    public class EmpruntRepository
    {
        public DataTable GetClients()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT IdClient, (Nom + ' ' + Prenom) AS NomComplet FROM Client";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }


        public DataTable GetDVDsDisponibles()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT IdDVD, Titre FROM DVD WHERE Disponible = 1";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public bool ClientEnRetard(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT COUNT(*) 
                FROM Emprunt
                WHERE IdClient = @id
                  AND DateRetourEffective IS NULL
                  AND DateRetourPrevue < GETDATE()";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idClient);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public int AjouterEmprunt(int idClient, int idDVD, DateTime dateRetourPrevue)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                var tran = conn.BeginTransaction();

                try
                {
                    int idEmprunt;

                    // Insertion dans Emprunt + récupération de l'ID
                    string sql = @"
                INSERT INTO Emprunt (IdClient, IdDVD, DateRetourPrevue)
                VALUES (@idClient, @idDVD, @dateRetourPrevue);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (var cmd = new SqlCommand(sql, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@idClient", idClient);
                        cmd.Parameters.AddWithValue("@idDVD", idDVD);
                        cmd.Parameters.AddWithValue("@dateRetourPrevue", dateRetourPrevue);
                        idEmprunt = (int)cmd.ExecuteScalar();
                    }

                    // Mettre le DVD en indisponible
                    string sqlUpdate = "UPDATE DVD SET Disponible = 0 WHERE IdDVD = @idDVD";
                    using (var cmd = new SqlCommand(sqlUpdate, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@idDVD", idDVD);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return idEmprunt;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
        public int EnregistrerEmprunt(int idClient, int idDVD)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            INSERT INTO Emprunt (IdClient, IdDVD, DateEmprunt, DateRetourPrevue)
            VALUES (@client, @dvd, GETDATE(), DATEADD(DAY, 7, GETDATE()));
            SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@client", idClient);
                    cmd.Parameters.AddWithValue("@dvd", idDVD);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool ClientBloquePourEmprunt(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT 
                CASE 
                    WHEN C.CotisationEnOrdre = 0 THEN 1
                    WHEN EXISTS (
                        SELECT 1 
                        FROM Emprunt E
                        WHERE E.IdClient = C.IdClient
                          AND E.DateRetourEffective IS NULL
                          AND E.DateRetourPrevue < GETDATE()
                    ) THEN 1
                    ELSE 0
                END AS Bloque
            FROM Client C
            WHERE C.IdClient = @id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idClient);
                    return (int)cmd.ExecuteScalar() == 1;
                }
            }
        }

        public DataTable GetEmpruntsEnCours()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT E.IdEmprunt, D.Titre, (C.Nom + ' ' + C.Prenom) AS NomClient,
                       E.DateEmprunt, E.DateRetourPrevue
                FROM Emprunt E
                JOIN Client C ON E.IdClient = C.IdClient
                JOIN DVD D ON E.IdDVD = D.IdDVD
                WHERE E.DateRetourEffective IS NULL";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void EnregistrerRetour(int idEmprunt, DateTime dateRetour, decimal tarifParJour)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                var tran = conn.BeginTransaction();

                try
                {
                    DateTime datePrevue;
                    int idDVD;

                    string sqlSelect = "SELECT DateRetourPrevue, IdDVD FROM Emprunt WHERE IdEmprunt = @id";
                    using (var cmd = new SqlCommand(sqlSelect, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@id", idEmprunt);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read()) return;
                            datePrevue = reader.GetDateTime(0);
                            idDVD = reader.GetInt32(1);
                        }
                    }

                    decimal amende = 0;
                    int joursRetard = (dateRetour - datePrevue).Days;
                    if (joursRetard > 0) amende = joursRetard * tarifParJour;

                    string sqlUpdate = @"UPDATE Emprunt
                                     SET DateRetourEffective = @dateRetour,
                                         Amende = @amende
                                     WHERE IdEmprunt = @id";
                    using (var cmd = new SqlCommand(sqlUpdate, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@dateRetour", dateRetour);
                        cmd.Parameters.AddWithValue("@amende", amende);
                        cmd.Parameters.AddWithValue("@id", idEmprunt);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlDVD = "UPDATE DVD SET Disponible = 1 WHERE IdDVD = @idDVD";
                    using (var cmd = new SqlCommand(sqlDVD, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@idDVD", idDVD);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

    }
}
