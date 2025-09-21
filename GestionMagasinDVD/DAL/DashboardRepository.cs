using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace GestionMagasinDVD.DAL
{
    public class DashboardRepository
    {
        public int GetDVDDispo()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM DVD WHERE Disponible = 1";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public int GetDVDEnPret()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM DVD WHERE Disponible = 0";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable GetDVDEnRetard()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT D.Titre AS [Titre DVD],
                   C.Nom AS [Nom Client],
                   C.Prenom AS [Prénom Client],
                   E.DateRetourPrevue AS [Date Retour Prévue]
            FROM Emprunt E
            JOIN DVD D ON E.IdDVD = D.IdDVD
            JOIN Client C ON E.IdClient = C.IdClient
            WHERE E.DateRetourEffective IS NULL
              AND E.DateRetourPrevue < GETDATE()
            ORDER BY E.DateRetourPrevue ASC";

                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public void EnvoyerEmail(string destinataire, string sujet, string corps)
        {
            var smtp = new SmtpClient("smtp.office365.com", 587)
            {
                Credentials = new NetworkCredential("Victoire.OKITODIMBA@student.hel.be", "e6vn2KLK"),
                EnableSsl = true
            };

            var mail = new MailMessage("Victoire.OKITODIMBA@student.hel.be", destinataire, sujet, corps);
            smtp.Send(mail);
        }
        public DataTable GetClientsEnRetardOuCotisation()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT DISTINCT 
                C.IdClient,
                (C.Nom + ' ' + C.Prenom) AS NomClient,
                CASE 
                    WHEN C.CotisationEnOrdre = 0 THEN 'Cotisation en retard'
                    WHEN EXISTS (
                        SELECT 1 FROM Emprunt E
                        WHERE E.IdClient = C.IdClient
                          AND E.DateRetourEffective IS NULL
                          AND E.DateRetourPrevue < GETDATE()
                    ) THEN 'DVD en retard'
                END AS Motif
            FROM Client C
            LEFT JOIN Emprunt E ON E.IdClient = C.IdClient
            WHERE C.CotisationEnOrdre = 0
               OR (E.DateRetourEffective IS NULL AND E.DateRetourPrevue < GETDATE())";

                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public DataTable GetEmpruntsARappeler()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT 
                E.IdEmprunt,
                (C.Nom + ' ' + C.Prenom) AS NomClient,
                C.Email,
                D.Titre AS TitreDVD,
                E.DateRetourPrevue
            FROM Emprunt E
            JOIN Client C ON E.IdClient = C.IdClient
            JOIN DVD D ON E.IdDVD = D.IdDVD
            WHERE E.DateRetourEffective IS NULL
              AND (
                    E.DateRetourPrevue < GETDATE()
                 OR C.CotisationEnOrdre = 0
              )
            ORDER BY E.DateRetourPrevue";

                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void EnvoyerRappel(int idEmprunt, string message)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"INSERT INTO Rappel (IdEmprunt, DateRappel, Message)
                       VALUES (@id, GETDATE(), @msg)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmprunt);
                    cmd.Parameters.AddWithValue("@msg", message);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public decimal GetMontantAmendes()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT ISNULL(SUM(Amende),0) FROM Emprunt
                           WHERE Amende > 0 AND DateRetourEffective IS NULL";
                using (var cmd = new SqlCommand(sql, conn))
                    return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int GetRappelsAEnvoyer()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT COUNT(*) FROM Emprunt
                           WHERE DateRetourEffective IS NULL
                           AND DateRetourPrevue < GETDATE()
                           AND IdEmprunt NOT IN (SELECT IdEmprunt FROM Rappel)";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public int GetClientsRetardCotisation()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM Client WHERE CotisationEnOrdre = 0";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable GetClientsEnRetard()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT E.IdEmprunt,
                   (C.Nom + ' ' + C.Prenom) AS NomClient,
                   C.Email,
                   D.Titre AS TitreDVD,
                   E.DateRetourPrevue
            FROM Emprunt E
            JOIN Client C ON E.IdClient = C.IdClient
            JOIN DVD D ON E.IdDVD = D.IdDVD
            WHERE E.DateRetourEffective IS NULL
              AND E.DateRetourPrevue < GETDATE()
              AND E.IdEmprunt NOT IN (SELECT IdEmprunt FROM Rappel)";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        
        public int CountDVDEnRetard()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT COUNT(*) 
                       FROM Emprunt
                       WHERE DateRetourEffective IS NULL
                         AND DateRetourPrevue < GETDATE()";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public int CountClientsRetardDVD()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT COUNT(DISTINCT IdClient)
                       FROM Emprunt
                       WHERE DateRetourEffective IS NULL
                         AND DateRetourPrevue < GETDATE()";
                using (var cmd = new SqlCommand(sql, conn))
                    return (int)cmd.ExecuteScalar();
            }
        }


        public DataTable GetRetoursPrevus()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT D.Titre AS [Titre DVD],
                       C.Nom AS [Nom Client],
                       C.Prenom AS [Prénom Client],
                       E.DateRetourPrevue AS [Date Retour Prévue]
                FROM Emprunt E
                JOIN DVD D ON E.IdDVD = D.IdDVD
                JOIN Client C ON E.IdClient = C.IdClient
                WHERE E.DateRetourEffective IS NULL
                  AND E.DateRetourPrevue BETWEEN CAST(GETDATE() AS DATE)
                                             AND DATEADD(DAY, 1, CAST(GETDATE() AS DATE))
                ORDER BY E.DateRetourPrevue ASC";

                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public DataTable GetDerniersEmprunts()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT TOP 10 
                       E.DateEmprunt AS [Date Emprunt],
                       D.Titre AS [Titre DVD],
                       C.Nom AS [Nom Client],
                       C.Prenom AS [Prénom Client]
                FROM Emprunt E
                JOIN DVD D ON E.IdDVD = D.IdDVD
                JOIN Client C ON E.IdClient = C.IdClient
                ORDER BY E.DateEmprunt DESC";

                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
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

        public bool ClientPeutEmprunter(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT COUNT(*) 
            FROM Client 
            WHERE IdClient = @id 
              AND CotisationEnOrdre = 1
              AND IdClient NOT IN (
                  SELECT IdClient FROM Emprunt
                  WHERE DateRetourEffective IS NULL
                    AND DateRetourPrevue < GETDATE()
              )";
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
                string sql = @"
            INSERT INTO Emprunt (IdClient, IdDVD, DateRetourPrevue)
            OUTPUT INSERTED.IdEmprunt
            VALUES (@c, @d, @dr);

            UPDATE DVD SET Disponible = 0 WHERE IdDVD = @d;";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@c", idClient);
                    cmd.Parameters.AddWithValue("@d", idDVD);
                    cmd.Parameters.AddWithValue("@dr", dateRetourPrevue);

                    // Retourne l'IdEmprunt créé
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Envoie des rappels automatiques
        public int EnvoyerRappelsAutomatiques()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            INSERT INTO Rappel (IdEmprunt, Message)
            SELECT E.IdEmprunt, 'DVD en retard : merci de le rendre dès que possible.'
            FROM Emprunt E
            WHERE E.DateRetourEffective IS NULL
              AND E.DateRetourPrevue < GETDATE()
              AND E.IdEmprunt NOT IN (SELECT IdEmprunt FROM Rappel)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    return cmd.ExecuteNonQuery(); // renvoie le nombre de rappels ajoutés
                }
            }
        }

        // Génération HTML du stock
        public string GenererHTMLStock()
        {
            var sb = new StringBuilder();
            sb.Append("<html><body><h1>Stock DVD</h1><table border='1'>");
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT Titre, Disponible FROM DVD";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    sb.Append("<tr><th>Titre</th><th>Disponible</th></tr>");
                    while (reader.Read())
                    {
                        sb.Append("<tr>");
                        sb.Append($"<td>{reader["Titre"]}</td>");
                        sb.Append($"<td>{((bool)reader["Disponible"] ? "Oui" : "Non")}</td>");
                        sb.Append("</tr>");
                    }
                }
            }
            sb.Append("</table></body></html>");
            return sb.ToString();
        }

        // Liste des DVD en prêt
        public DataTable GetDVDEnPretListe()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT * FROM DVD WHERE Disponible = 0";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        public DataTable GetEmpruntsEnCours()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT E.IdEmprunt,
                   (D.Titre + ' - ' + C.Nom + ' ' + C.Prenom) AS Description
            FROM Emprunt E
            JOIN DVD D ON E.IdDVD = D.IdDVD
            JOIN Client C ON E.IdClient = C.IdClient
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

        public void RetournerDVD(int idEmprunt)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            UPDATE Emprunt
            SET DateRetourEffective = GETDATE(),
                Amende = CASE 
                           WHEN GETDATE() > DateRetourPrevue 
                           THEN DATEDIFF(DAY, DateRetourPrevue, GETDATE()) * 1.5
                           ELSE 0
                         END
            WHERE IdEmprunt = @id;

            UPDATE DVD
            SET Disponible = 1
            WHERE IdDVD = (SELECT IdDVD FROM Emprunt WHERE IdEmprunt = @id);";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmprunt);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetInfosEmprunt(int idEmprunt)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT 
                (C.Nom + ' ' + C.Prenom) AS NomClient,
                D.Titre AS TitreDVD,
                E.DateEmprunt,
                E.DateRetourPrevue,
                ISNULL(E.Amende, 0) AS Amende
            FROM Emprunt E
            INNER JOIN Client C ON E.IdClient = C.IdClient
            INNER JOIN DVD D ON E.IdDVD = D.IdDVD
            WHERE E.IdEmprunt = @id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmprunt);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
        public void MarquerRappelEnvoye(int idEmprunt)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "INSERT INTO Rappel (IdEmprunt, DateRappel) VALUES (@id, GETDATE())";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmprunt);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetClientsPourRappel()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT DISTINCT C.IdClient, (C.Nom + ' ' + C.Prenom) AS NomComplet
            FROM Emprunt E
            JOIN Client C ON C.IdClient = E.IdClient
            WHERE E.DateRetourEffective IS NULL
              AND E.DateRetourPrevue < GETDATE()
              AND E.IdEmprunt NOT IN (SELECT IdEmprunt FROM Rappel)";
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public DataTable GetClientsEnRetardParClient(int idClient)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
            SELECT E.IdEmprunt,
                   (C.Nom + ' ' + C.Prenom) AS NomClient,
                   C.Email,
                   D.Titre AS TitreDVD,
                   E.DateRetourPrevue
            FROM Emprunt E
            JOIN Client C ON E.IdClient = C.IdClient
            JOIN DVD D ON E.IdDVD = D.IdDVD
            WHERE E.DateRetourEffective IS NULL
              AND E.DateRetourPrevue < GETDATE()
              AND E.IdEmprunt NOT IN (SELECT IdEmprunt FROM Rappel)
              AND C.IdClient = @id";
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








    }
}
