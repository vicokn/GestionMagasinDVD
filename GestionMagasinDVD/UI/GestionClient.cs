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
    public partial class GestionClient : Form
    {
        ClientRepository repo = new ClientRepository();
        int? idClient = null;

        public GestionClient()
        {
            InitializeComponent();
            lblDateInscription.Text = DateTime.Now.ToShortDateString();
        }

        public GestionClient(int id) : this()
        {
            idClient = id;
            ChargerClient();
        }

        private void ChargerClient()
        {
            var table = repo.GetClientById(idClient.Value);
            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                txtNom.Text = row["Nom"].ToString();
                txtPrenom.Text = row["Prenom"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtTelephone.Text = row["Telephone"].ToString();
                txtAdresse.Text = row["Adresse"].ToString();
                chkCotisation.Checked = Convert.ToBoolean(row["CotisationEnOrdre"]);
                lblDateInscription.Text = Convert.ToDateTime(row["DateInscription"]).ToShortDateString();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            string tel = string.IsNullOrWhiteSpace(txtTelephone.Text) ? null : txtTelephone.Text.Trim();
            string adr = string.IsNullOrWhiteSpace(txtAdresse.Text) ? null : txtAdresse.Text.Trim();

            if (idClient == null)
                repo.AjouterClient(txtNom.Text.Trim(), txtPrenom.Text.Trim(), txtEmail.Text.Trim(), tel, adr, chkCotisation.Checked);
            else
                repo.ModifierClient(idClient.Value, txtNom.Text.Trim(), txtPrenom.Text.Trim(), txtEmail.Text.Trim(), tel, adr, chkCotisation.Checked);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
