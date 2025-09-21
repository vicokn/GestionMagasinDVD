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
    public partial class GestionDVD : Form
    {
        DVDRepository repo = new DVDRepository();
        int? idDVD = null;

        public GestionDVD()
        {
            InitializeComponent();
            ChargerRealisateurs();
            InstallerGridActeurs();
            chkDisponible.Checked = true;
            numPrix.DecimalPlaces = 2;
            numPrix.Minimum = 0;
        }

        public GestionDVD(int id) : this()
        {
            idDVD = id;
            ChargerDVD();
        }

        private void ChargerRealisateurs()
        {
            var t = repo.GetRealisateurs();
            cboRealisateur.DataSource = t;
            cboRealisateur.DisplayMember = "NomComplet";
            cboRealisateur.ValueMember = "IdRealisateur";
        }

        private void InstallerGridActeurs()
        {
            gridActeurs.AutoGenerateColumns = false;
            gridActeurs.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "IdActeur",
                HeaderText = "IdActeur",
                Visible = false
            };
            var colNom = new DataGridViewTextBoxColumn
            {
                Name = "NomComplet",
                HeaderText = "Acteur",
                ReadOnly = true,
                Width = 200
            };
            var colRole = new DataGridViewTextBoxColumn
            {
                Name = "Role",
                HeaderText = "Rôle",
                Width = 180
            };

            gridActeurs.Columns.AddRange(colId, colNom, colRole);
        }

        private void ChargerDVD()
        {
            // 1. Charger les infos du DVD
            var dvd = repo.GetDVDById(idDVD.Value);
            if (dvd.Rows.Count == 0) return;

            var row = dvd.Rows[0];

            txtTitre.Text = row["Titre"].ToString();
            chkDisponible.Checked = Convert.ToBoolean(row["Disponible"]);
            numPrix.Value = Convert.ToDecimal(row["PrixLocation"]);
            cboRealisateur.SelectedValue = Convert.ToInt32(row["IdRealisateur"]);

            if (row["AnneeSortie"] != DBNull.Value)
                numAnnee.Value = Convert.ToInt32(row["AnneeSortie"]);

            // 2. Charger les acteurs liés à ce DVD
            var acteurs = repo.GetActeursByDVD(idDVD.Value);
            gridActeurs.Rows.Clear();
            foreach (DataRow r in acteurs.Rows)
            {
                gridActeurs.Rows.Add(
                    r["IdActeur"],
                    r["NomComplet"],
                    r["Role"]?.ToString()
                );
            }
        }


        private void btnAjouterActeur_Click(object sender, EventArgs e)
        {
            using (var dlg = new SelectionActeurDialog(repo.GetActeurs()))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {          

                    // Ajoute l'acteur avec un rôle vide (l'utilisateur pourra le remplir directement dans la cellule)
                    gridActeurs.Rows.Add(dlg.IdActeurSelectionne, dlg.NomComplet, "");
                }
            }
        }

        private void btnRetirerActeur_Click(object sender, EventArgs e)
        {
            if (gridActeurs.CurrentRow != null)
                gridActeurs.Rows.Remove(gridActeurs.CurrentRow);
        }

        private List<(int idActeur, string role)> LireActeursDepuisGrille()
        {
            var list = new List<(int, string)>();
            foreach (DataGridViewRow row in gridActeurs.Rows)
            {
                if (row.IsNewRow) continue;
                int idActeur = Convert.ToInt32(row.Cells["IdActeur"].Value);
                string role = row.Cells["Role"].Value?.ToString();
                list.Add((idActeur, role));
            }
            return list;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitre.Text))
            {
                MessageBox.Show("Le titre est obligatoire.");
                return;
            }
            if (cboRealisateur.SelectedValue == null)
            {
                MessageBox.Show("Sélectionne un réalisateur.");
                return;
            }

            string titre = txtTitre.Text.Trim();
            int idR = (int)cboRealisateur.SelectedValue;
            int? annee = (int?)numAnnee.Value;
            bool dispo = chkDisponible.Checked;
            decimal prix = numPrix.Value;

            var acteurs = LireActeursDepuisGrille();

            if (idDVD == null)
            {
                int newId = repo.AjouterDVD(titre, annee, idR, dispo, prix, acteurs);
                idDVD = newId;
            }
            else
            {
                repo.ModifierDVD(idDVD.Value, titre, annee, idR, dispo, prix, acteurs);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAjouterRealisateur_Click(object sender, EventArgs e)
        {
            using (var f = new GestionRealisateur())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ChargerRealisateurs();
                    cboRealisateur.SelectedValue = f.IdRealisateurCree;
                }
            }
        }
    }
}
