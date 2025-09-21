using GestionMagasinDVD.DAL;
using GestionMagasinDVD.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasinDVD
{
    public partial class FormDVD : UserControl
    {
        DVDRepository repo = new DVDRepository();
        public FormDVD()
        {
            InitializeComponent();
            ChargerDVDs();
        }

        private void ChargerDVDs()
        {
            dataGridViewDVDs.DataSource = repo.GetDVDs();

            // Masquer les colonnes techniques
            if (dataGridViewDVDs.Columns.Contains("IdDVD"))
                dataGridViewDVDs.Columns["IdDVD"].Visible = false;
            if (dataGridViewDVDs.Columns.Contains("IdRealisateur"))
                dataGridViewDVDs.Columns["IdRealisateur"].Visible = false;

            // Renommer les en-têtes
            if (dataGridViewDVDs.Columns.Contains("Titre"))
                dataGridViewDVDs.Columns["Titre"].HeaderText = "Titre";
            if (dataGridViewDVDs.Columns.Contains("AnneeSortie"))
                dataGridViewDVDs.Columns["AnneeSortie"].HeaderText = "Année";
            if (dataGridViewDVDs.Columns.Contains("Realisateur"))
                dataGridViewDVDs.Columns["Realisateur"].HeaderText = "Réalisateur";
            if (dataGridViewDVDs.Columns.Contains("Disponible"))
                dataGridViewDVDs.Columns["Disponible"].HeaderText = "Disponible ?";
            if (dataGridViewDVDs.Columns.Contains("PrixLocation"))
                dataGridViewDVDs.Columns["PrixLocation"].HeaderText = "Prix location (€)";
        }
        private void btnAjouterDVD_Click(object sender, EventArgs e)
        {
            using (var f = new GestionDVD())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    ChargerDVDs();
            }
        }

        private void btnModifierDVD_Click(object sender, EventArgs e)
        {
            if (dataGridViewDVDs.CurrentRow != null)
            {
                int idDVD = (int)dataGridViewDVDs.CurrentRow.Cells["IdDVD"].Value;
                using (var f = new GestionDVD(idDVD))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                        ChargerDVDs(); // recharge la liste après modif
                }
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string q = txtRecherche.Text.Trim();
            if (string.IsNullOrEmpty(q))
                ChargerDVDs();
            else
                dataGridViewDVDs.DataSource = repo.RechercherDVD(q);
        }

        private void btnSupprimerDVD_Click(object sender, EventArgs e)
        {
            if (dataGridViewDVDs.CurrentRow != null)
            {
                int idDVD = (int)dataGridViewDVDs.CurrentRow.Cells["IdDVD"].Value;
                if (MessageBox.Show("Supprimer ce DVD ? (les liens acteurs seront supprimés)",
                                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    repo.SupprimerUnDVDEtSesLiens(idDVD);
                    ChargerDVDs();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
