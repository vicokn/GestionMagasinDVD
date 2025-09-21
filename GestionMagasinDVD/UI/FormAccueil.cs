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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
            ChargerUserControl(new FormTableauDeBord());

        }
        public void ChargerUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new FormTableauDeBord());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new FormClient());
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new FormDVD());
        }

        private void btnAlerteRappel_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new FormAlertesRappels());

        }

        private void btnEmpruntsRetours_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new FormEmpruntsRetourscs());

        }

    }
}
