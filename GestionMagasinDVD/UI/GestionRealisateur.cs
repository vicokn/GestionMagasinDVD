using GestionMagasinDVD.DAL;
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

namespace GestionMagasinDVD.UI
{
    public partial class GestionRealisateur : Form
    {
        public int IdRealisateurCree { get; private set; }
        public GestionRealisateur()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez remplir le nom et le prénom.");
                return;
            }

            using (var conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    INSERT INTO Realisateur (Nom, Prenom)
                    VALUES (@nom, @prenom);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", txtNom.Text.Trim());
                    cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text.Trim());

                    // On récupère l'ID créé
                    IdRealisateurCree = (int)cmd.ExecuteScalar();
                }
            }

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
