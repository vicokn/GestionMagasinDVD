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
    public partial class FormEmpruntsRetourscs : UserControl
    {
        private readonly EmpruntRepository repo = new EmpruntRepository();
        private const decimal TarifAmendeParJour = 1.00m; // 1€ par jour de retard
        private bool _isLoadingClients = false;

        public FormEmpruntsRetourscs()
        {
            InitializeComponent();
            ChargerClients();
            ChargerDVDs();
            ChargerEmpruntsEnCours();
        }
        private void ChargerClients()
        {
            _isLoadingClients = true;
            cboClients.DataSource = repo.GetClients();
            cboClients.DisplayMember = "NomComplet";
            cboClients.ValueMember = "IdClient";
            _isLoadingClients = false;
        }

        private void ChargerDVDs()
        {
            cboDVDs.DataSource = repo.GetDVDsDisponibles();
            cboDVDs.DisplayMember = "Titre";
            cboDVDs.ValueMember = "IdDVD";
        }

        private void ChargerEmpruntsEnCours()
        {
            dgvEmpruntsEnCours.AllowUserToAddRows = false;
            dgvEmpruntsEnCours.DataSource = repo.GetEmpruntsEnCours();
            if (dgvEmpruntsEnCours.Columns.Contains("IdEmprunt"))
                dgvEmpruntsEnCours.Columns["IdEmprunt"].Visible = false;
        }

       

        private void btnEnregistrerEmprunt_Click_1(object sender, EventArgs e)
        {
            if (cboClients.SelectedValue == null || cboDVDs.SelectedValue == null)
                return;

            int idClient = (int)cboClients.SelectedValue;
            int idDVD = (int)cboDVDs.SelectedValue;

            if (repo.ClientEnRetard(idClient))
            {
                MessageBox.Show("Ce client ne peut pas emprunter car il a un DVD en retard ou une cotisation non à jour.",
                "Emprunt refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dateRetourPrevue = dtpRetourPrevu.Value;

            // 👉 Vérification : pas de retour prévu avant aujourd’hui
            if (dateRetourPrevue.Date < DateTime.Today)
            {
                MessageBox.Show("Vous ne pouvez pas rendre dans le passé.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmprunt = repo.AjouterEmprunt(idClient, idDVD, dateRetourPrevue);

            var bordereau = new FormBordereau(idEmprunt);
            bordereau.ShowDialog();

            ChargerClients();
            ChargerDVDs();
        }

        private void btnEnregistrerRetour_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpruntsEnCours.CurrentRow == null) return;

            int idEmprunt = (int)dgvEmpruntsEnCours.CurrentRow.Cells["IdEmprunt"].Value;
            repo.EnregistrerRetour(idEmprunt, DateTime.Now, TarifAmendeParJour);

            ChargerClients();
            ChargerDVDs();
            ChargerEmpruntsEnCours();
        }

        private void cboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingClients) return; // on ignore pendant le chargement
            if (cboClients.SelectedValue == null) return;
            if (!(cboClients.SelectedValue is int)) return;

            int idClient = (int)cboClients.SelectedValue;
            if (repo.ClientBloquePourEmprunt(idClient))
            {
                lblMessage.Text = "Ce client a un DVD en retard ou une cotisation non à jour.";
                lblMessage.ForeColor = Color.Red;
                btnEnregistrerEmprunt.Enabled = false;
            }
            else
            {
                lblMessage.Text = "";
                btnEnregistrerEmprunt.Enabled = true;
            }
        }

    }
}
