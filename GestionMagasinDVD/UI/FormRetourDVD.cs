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
    public partial class FormRetourDVD : Form
    {
        DashboardRepository repo = new DashboardRepository();

        public FormRetourDVD()
        {
            InitializeComponent();
            ChargerEmpruntsEnCours();
        }

        private void ChargerEmpruntsEnCours()
        {
            cbEmprunts.DataSource = repo.GetEmpruntsEnCours();
            cbEmprunts.DisplayMember = "Description";
            cbEmprunts.ValueMember = "IdEmprunt";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbEmprunts.SelectedValue is int idEmprunt)
            {
                repo.RetournerDVD(idEmprunt);
                MessageBox.Show("Retour enregistré avec succès !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void cbEmprunts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbEmprunts.SelectedValue is int idEmprunt)
            {
                var infos = repo.GetInfosEmprunt(idEmprunt);
                if (infos.Rows.Count > 0)
                {
                    lblClient.Text = infos.Rows[0]["NomClient"].ToString();
                    lblDVD.Text = infos.Rows[0]["TitreDVD"].ToString();
                    lblDateRetour.Text = Convert
                        .ToDateTime(infos.Rows[0]["DateRetourPrevue"])
                        .ToShortDateString();
                }
            }
        }
    }
}
