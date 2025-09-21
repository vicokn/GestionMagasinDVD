using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace GestionMagasinDVD
{
    public partial class FormConnexion : Form
    {
        
        public FormConnexion()
        {
            InitializeComponent();
            lblErreur.Visible = false; // On cache l’erreur au départ
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxMdp.Text;

            if (username == "a" && password == "a")
            {
                FormAccueil accueil = new FormAccueil();
                this.Hide();
                accueil.ShowDialog();
                this.Close();
            }
            else
            {
                lblErreur.Text = "Nom d'utilisateur ou mot de passe incorrect !";
                lblErreur.Visible = true;
            }
        }
    }
}
