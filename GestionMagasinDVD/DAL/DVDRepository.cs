using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasinDVD.DAL
{
    public class DVDRepository
    {
        public DataTable GetDVDs()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT D.IdDVD, D.Titre, D.AnneeSortie, 
                       D.IdRealisateur, (R.Nom + ' ' + R.Prenom) AS Realisateur,
                       D.Disponible, D.PrixLocation
                FROM DVD D
                JOIN Realisateur R ON D.IdRealisateur = R.IdRealisateur
                ORDER BY D.Titre";
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    var t = new DataTable();
                    da.Fill(t);
                    return t;
                }
            }
        }

        public DataTable GetRealisateurs()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT IdRealisateur, (Nom + ' ' + Prenom) AS NomComplet FROM Realisateur ORDER BY Nom, Prenom";
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    var t = new DataTable();
                    da.Fill(t);
                    return t;
                }
            }
        }

        public DataTable GetActeurs()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT IdActeur, (Nom + ' ' + Prenom) AS NomComplet FROM Acteur ORDER BY Nom, Prenom";
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    var t = new DataTable();
                    da.Fill(t);
                    return t;
                }
            }
        }

        public DataTable GetDVDById(int idDVD)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"SELECT IdDVD, Titre, AnneeSortie, IdRealisateur, Disponible, PrixLocation
                               FROM DVD WHERE IdDVD = @id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDVD);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var t = new DataTable();
                        da.Fill(t);
                        return t;
                    }
                }
            }
        }

        // Acteurs (avec rôle) d’un DVD
        public DataTable GetActeursByDVD(int idDVD)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT A.IdActeur, (A.Nom + ' ' + A.Prenom) AS NomComplet, DA.Role
                FROM DVD_Acteur DA
                JOIN Acteur A ON A.IdActeur = DA.IdActeur
                WHERE DA.IdDVD = @id
                ORDER BY A.Nom, A.Prenom";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDVD);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var t = new DataTable();
                        da.Fill(t);
                        return t;
                    }
                }
            }
        }

        public DataTable RechercherDVD(string recherche)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                SELECT DISTINCT D.IdDVD, D.Titre, D.AnneeSortie, 
                                D.IdRealisateur, (R.Nom + ' ' + R.Prenom) AS Realisateur,
                                D.Disponible, D.PrixLocation
                FROM DVD D
                JOIN Realisateur R ON D.IdRealisateur = R.IdRealisateur
                LEFT JOIN DVD_Acteur DA ON DA.IdDVD = D.IdDVD
                LEFT JOIN Acteur A ON A.IdActeur = DA.IdActeur
                WHERE D.Titre LIKE @q OR R.Nom LIKE @q OR R.Prenom LIKE @q 
                   OR A.Nom LIKE @q OR A.Prenom LIKE @q";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + recherche + "%");
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var t = new DataTable();
                        da.Fill(t);
                        return t;
                    }
                }
            }
        }

        // Ajout DVD + ses acteurs (transaction)
        public int AjouterDVD(string titre, int? annee, int idRealisateur, bool disponible, decimal prixLocation,
                              IEnumerable<(int idActeur, string role)> acteurs)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlDVD = @"
                        INSERT INTO DVD (Titre, AnneeSortie, IdRealisateur, Disponible, PrixLocation)
                        VALUES (@titre, @annee, @rea, @dispo, @prix);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        int idDVD;
                        using (var cmd = new SqlCommand(sqlDVD, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@titre", titre);
                            cmd.Parameters.AddWithValue("@annee", (object)annee ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@rea", idRealisateur);
                            cmd.Parameters.AddWithValue("@dispo", disponible);
                            cmd.Parameters.AddWithValue("@prix", prixLocation);
                            idDVD = (int)cmd.ExecuteScalar();
                        }

                        if (acteurs != null)
                        {
                            foreach (var (idActeur, role) in acteurs)
                            {
                                string sqlDA = @"INSERT INTO DVD_Acteur (IdDVD, IdActeur, Role) VALUES (@dvd, @act, @role)";
                                using (var cmd = new SqlCommand(sqlDA, conn, tx))
                                {
                                    cmd.Parameters.AddWithValue("@dvd", idDVD);
                                    cmd.Parameters.AddWithValue("@act", idActeur);
                                    cmd.Parameters.AddWithValue("@role", (object)role ?? DBNull.Value);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();
                        return idDVD;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        // Modification DVD + remplacement des acteurs (transaction)
        public void ModifierDVD(int idDVD, string titre, int? annee, int idRealisateur, bool disponible, decimal prixLocation,
                                IEnumerable<(int idActeur, string role)> acteurs)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlDVD = @"
                        UPDATE DVD
                        SET Titre = @titre, AnneeSortie = @annee, IdRealisateur = @rea,
                            Disponible = @dispo, PrixLocation = @prix
                        WHERE IdDVD = @id";
                        using (var cmd = new SqlCommand(sqlDVD, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", idDVD);
                            cmd.Parameters.AddWithValue("@titre", titre);
                            cmd.Parameters.AddWithValue("@annee", (object)annee ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@rea", idRealisateur);
                            cmd.Parameters.AddWithValue("@dispo", disponible);
                            cmd.Parameters.AddWithValue("@prix", prixLocation);
                            cmd.ExecuteNonQuery();
                        }

                        string del = "DELETE FROM DVD_Acteur WHERE IdDVD = @id";
                        using (var cmd = new SqlCommand(del, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", idDVD);
                            cmd.ExecuteNonQuery();
                        }

                        if (acteurs != null)
                        {
                            foreach (var (idActeur, role) in acteurs)
                            {
                                string sqlDA = @"INSERT INTO DVD_Acteur (IdDVD, IdActeur, Role) VALUES (@dvd, @act, @role)";
                                using (var cmd = new SqlCommand(sqlDA, conn, tx))
                                {
                                    cmd.Parameters.AddWithValue("@dvd", idDVD);
                                    cmd.Parameters.AddWithValue("@act", idActeur);
                                    cmd.Parameters.AddWithValue("@role", (object)role ?? DBNull.Value);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public void SupprimerUnDVDEtSesLiens(int idDVD)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                // 1. Supprimer les rappels liés aux emprunts de ce DVD
                string sqlRappel = @"
            DELETE FROM Rappel
            WHERE idEmprunt IN (SELECT idEmprunt FROM Emprunt WHERE idDVD = @id)";
                using (var cmdRappel = new SqlCommand(sqlRappel, conn))
                {
                    cmdRappel.Parameters.AddWithValue("@id", idDVD);
                    cmdRappel.ExecuteNonQuery();
                }

                // 2. Supprimer les emprunts liés à ce DVD
                string sqlEmprunt = "DELETE FROM Emprunt WHERE idDVD = @id";
                using (var cmdEmprunt = new SqlCommand(sqlEmprunt, conn))
                {
                    cmdEmprunt.Parameters.AddWithValue("@id", idDVD);
                    cmdEmprunt.ExecuteNonQuery();
                }

                // 3. Supprimer les acteurs liés à ce DVD
                string sqlActeurs = "DELETE FROM DVD_Acteur WHERE IdDVD = @id";
                using (var cmdActeurs = new SqlCommand(sqlActeurs, conn))
                {
                    cmdActeurs.Parameters.AddWithValue("@id", idDVD);
                    cmdActeurs.ExecuteNonQuery();
                }

                // 4. Supprimer le DVD
                string sqlDVD = "DELETE FROM DVD WHERE IdDVD = @id";
                using (var cmdDVD = new SqlCommand(sqlDVD, conn))
                {
                    cmdDVD.Parameters.AddWithValue("@id", idDVD);
                    cmdDVD.ExecuteNonQuery();
                }
            }
        }
        public void AjouterRealisateur(string nom, string prenom)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "INSERT INTO Realisateur (Nom, Prenom) VALUES (@nom, @prenom)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AjouterActeur(string nom, string prenom)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = "INSERT INTO Acteur (Nom, Prenom) VALUES (@nom, @prenom)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
