using GestionMagasinDVD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasinDVD.UI
{
    public partial class FormAlertesRappels : UserControl
    {
        DashboardRepository repo = new DashboardRepository();
        public FormAlertesRappels()
        {
            InitializeComponent();
            ChargerRappels();
        }
        private void ChargerRappels()
        {
            var table = repo.GetEmpruntsARappeler(); // nouvelle méthode
            dataGridViewRappels.AllowUserToAddRows = false;
            dataGridViewRappels.ReadOnly = true;
            dataGridViewRappels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRappels.DataSource = table;
            labelNbRappels.Text = $"Rappels à envoyer : {table.Rows.Count}";
        }
       

        private void FormAlertesRappels_Load(object sender, EventArgs e)
        {
           
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerRappels();
        }

        private void btnEnvoyerRappel_Click(object sender, EventArgs e)
        {
            var rappels = repo.GetEmpruntsARappeler();

            if (rappels.Rows.Count == 0)
            {
                MessageBox.Show("Aucun rappel à envoyer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("Rappels envoyés automatiquement.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChargerRappels(); // Recharge la grille
        }
    }
}
