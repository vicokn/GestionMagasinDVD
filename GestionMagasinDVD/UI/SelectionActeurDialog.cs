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
    public partial class SelectionActeurDialog : Form
    {
        DVDRepository repo = new DVDRepository();
        public int IdActeurSelectionne { get; private set; }
        public string NomComplet { get; private set; }

        public SelectionActeurDialog(DataTable acteurs)
        {
            InitializeComponent();

            cboActeurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActeurs.DisplayMember = "NomComplet";
            cboActeurs.ValueMember = "IdActeur";
            cboActeurs.DataSource = acteurs;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cboActeurs.SelectedValue != null)
            {
                IdActeurSelectionne = (int)cboActeurs.SelectedValue;
                NomComplet = cboActeurs.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAjouterNouveauActeur_Click(object sender, EventArgs e)
        {
            using (var f = new GestionActeur())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Recharge la liste des acteurs
                    cboActeurs.DataSource = repo.GetActeurs();
                    cboActeurs.SelectedValue = f.IdActeurCree;
                }
            }
        }
    }
}
