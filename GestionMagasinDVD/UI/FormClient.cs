using GestionMagasinDVD.DAL;
using GestionMagasinDVD.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasinDVD
{
    public partial class FormClient : UserControl
    {
        ClientRepository repo = new ClientRepository();
        public FormClient()
        {
            InitializeComponent();
            ChargerClients();
        }

        private void ChargerClients()
        {
            dataGridViewClients.DataSource = repo.GetClients();
            dataGridViewClients.Columns["IdClient"].Visible = false; // cacher l'ID
        }

        private void Client_Load(object sender, EventArgs e)
        {
           
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();
            dataGridViewClients.DataSource = repo.RechercherClients(recherche);
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            using (var f = new GestionClient())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    ChargerClients();
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow != null)
            {
                // Récupère l'ID du client sélectionné
                int idClient = (int)dataGridViewClients.CurrentRow.Cells["IdClient"].Value;

                // Ouvre le form en mode modification
                using (var f = new GestionClient(idClient))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                        ChargerClients(); // rafraîchit la liste après modif
                }
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow != null)
            {
                int idClient = (int)dataGridViewClients.CurrentRow.Cells["IdClient"].Value;
                if (MessageBox.Show("Supprimer ce client et tous ses emprunts ?",
                                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    repo.SupprimerUnClientEtSesLiens(idClient);
                    ChargerClients();
                }
            }
        }
        

        
    }
}
