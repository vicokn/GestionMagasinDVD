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
    public partial class FormNouvelEmprunt : Form
    {
        DashboardRepository repo = new DashboardRepository();
        public FormNouvelEmprunt()
        {
            InitializeComponent();
            ChargerClients();
            ChargerDVDsDisponibles();
            dtpRetour.Value = DateTime.Now.AddDays(7); // par défaut 7 jours
        }

        private void ChargerClients()
        {
            cbClients.DataSource = repo.GetClients(); // DataTable avec IdClient, NomComplet
            cbClients.DisplayMember = "NomComplet";
            cbClients.ValueMember = "IdClient";
        }

        private void ChargerDVDsDisponibles()
        {
            cbDVDs.DataSource = repo.GetDVDsDisponibles(); // DataTable avec IdDVD, Titre
            cbDVDs.DisplayMember = "Titre";
            cbDVDs.ValueMember = "IdDVD";
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            if (cbClients.SelectedValue == null || cbDVDs.SelectedValue == null)
                return;

            int idClient = (int)cbClients.SelectedValue;
            int idDVD = (int)cbDVDs.SelectedValue;
            DateTime dateRetour = dtpRetour.Value;

            // 👉 Vérification : pas de retour prévu avant aujourd’hui
            if (dateRetour.Date < DateTime.Today)
            {
                MessageBox.Show("Vous ne pouvez pas rendre dans le passé.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!repo.ClientPeutEmprunter(idClient))
            {
                MessageBox.Show("Ce client ne peut pas emprunter (cotisation en retard ou DVD non rendu).");
                return;
            }

            int nouvelIdEmprunt = repo.AjouterEmprunt(idClient, idDVD, dateRetour);

            MessageBox.Show("Emprunt enregistré avec succès !");

            using (var f = new FormBordereau(nouvelIdEmprunt))
            {
                f.ShowDialog();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
