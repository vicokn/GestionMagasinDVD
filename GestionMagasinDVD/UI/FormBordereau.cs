using GestionMagasinDVD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasinDVD.UI
{
    public partial class FormBordereau : Form
    {
        DashboardRepository repo = new DashboardRepository();
        int idEmprunt;
        public FormBordereau(int id)
        {
            InitializeComponent();
            idEmprunt = id;
            ChargerBordereau();
        }

        private void ChargerBordereau()
        {
            var infos = repo.GetInfosEmprunt(idEmprunt);
            if (infos.Rows.Count > 0)
            {
                lblClient.Text = infos.Rows[0]["NomClient"].ToString();
                lblDVD.Text = infos.Rows[0]["TitreDVD"].ToString();
                lblDateEmprunt.Text = Convert.ToDateTime(infos.Rows[0]["DateEmprunt"]).ToShortDateString();
                lblDateRetour.Text = Convert.ToDateTime(infos.Rows[0]["DateRetourPrevue"]).ToShortDateString();
                lblAmende.Text = string.Format("{0:0.00} €", infos.Rows[0]["Amende"]);
            }
        }
        private void btnExporter_Click(object sender, EventArgs e)
        {
            string contenu =
                $"BORDEREAU D'EMPRUNT\n" +
                $"Client : {lblClient.Text}\n" +
                $"DVD : {lblDVD.Text}\n" +
                $"Date emprunt : {lblDateEmprunt.Text}\n" +
                $"Date retour prévue : {lblDateRetour.Text}\n" +
                $"Amende : {lblAmende.Text}\n";

            string chemin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "bordereau.txt");
            File.WriteAllText(chemin, contenu);

            MessageBox.Show($"Bordereau enregistré sur le bureau :\n{chemin}");
            System.Diagnostics.Process.Start("explorer.exe", chemin);
        }

        private void brnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
