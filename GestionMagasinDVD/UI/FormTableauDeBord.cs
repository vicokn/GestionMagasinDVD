using GestionMagasinDVD.DAL;
using GestionMagasinDVD.UI;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasinDVD
{
    public partial class FormTableauDeBord : UserControl
    {
        DashboardRepository repo = new DashboardRepository();
        public FormTableauDeBord()
        {
            InitializeComponent();
            ChargerInfos();
        }
        private void ChargerNbRappels()
        {
            var table = repo.GetEmpruntsARappeler();
        }

        private void ChargerInfos()
        {
            // Compteurs du haut
            label2.Text = repo.GetDVDDispo().ToString();                  // DVD dispo
            label3.Text = repo.GetDVDEnPret().ToString();                 // DVD en prêt
            label5.Text = repo.CountDVDEnRetard().ToString();               // DVD en retard de retour
            label7.Text = repo.GetMontantAmendes().ToString("0.00 €");    // Montant total amendes
            label11.Text = repo.GetClientsRetardCotisation().ToString();  // Clients en retard cotisation
            label13.Text = repo.CountClientsRetardDVD().ToString();         // Clients en retard de rentrée

            // Grilles du milieu
            dataGridClientEnRetard.AllowUserToAddRows = false;
            dataGridClientEnRetard.ReadOnly = true;
            dataGridClientEnRetard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientEnRetard.DataSource = repo.GetClientsEnRetardOuCotisation();
            dataGridViewDerniersEmprunts.DataSource = repo.GetDerniersEmprunts(); // Derniers emprunts
            dataGridViewRetoursPrevus.DataSource = repo.GetRetoursPrevus();       // Retours prévus aujourd'hui/demain
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnNouvelEmprunt_Click(object sender, EventArgs e)
        {
            using (var f = new FormNouvelEmprunt())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ChargerInfos(); // rafraîchir le tableau de bord
                }
            }
        }

        private void btnRetourDVD_Click(object sender, EventArgs e)
        {
            using (var f = new FormRetourDVD())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ChargerInfos();
                }

            }
        }

        private void btnEnvoyerRappels_Click(object sender, EventArgs e)
        {

            var rappels = repo.GetEmpruntsARappeler();

            if (rappels.Rows.Count == 0)
            {
                MessageBox.Show("Aucun rappel à envoyer pour le moment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataRow row in rappels.Rows)
            {
                int idEmprunt = Convert.ToInt32(row["IdEmprunt"]);
                string nomClient = row["NomClient"].ToString();
                string email = row["Email"].ToString();
                string titreDVD = row["TitreDVD"].ToString();

                string message = $"Bonjour {nomClient},\n\nVous avez un DVD en retard : \"{titreDVD}\".\nMerci de le retourner rapidement ou de régulariser votre cotisation.";

                repo.EnvoyerRappel(idEmprunt, message);
            }

            MessageBox.Show("Tous les rappels ont été envoyés .", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChargerNbRappels(); // Met à jour le label
        }

 


        private void btnVoirStockHTML_Click(object sender, EventArgs e)
        {
            var html = repo.GenererHTMLStock();
            File.WriteAllText("stock.html", html);
            Process.Start("stock.html");
        }

        private void btnReleveSortis_Click(object sender, EventArgs e)
        {
            var table = repo.GetDVDEnPretListe();
            new FormListe(table).ShowDialog();
        }

        private void btnReleveRetard_Click(object sender, EventArgs e)
        {
            var table = repo.GetDVDEnRetard();
            new FormListe(table).ShowDialog();
        }

        private void btnEnvoyerTestEmail_Click(object sender, EventArgs e)
        {
            try
            {
                repo.EnvoyerEmail("victoire4800@outlook.com", "Test SMTP", "Ceci est un test d'envoi depuis l'application.");
                MessageBox.Show("Email de test envoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
