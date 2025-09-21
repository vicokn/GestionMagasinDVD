namespace GestionMagasinDVD.UI
{
    partial class SelectionActeurDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboActeurs = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterNouveauActeur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboActeurs
            // 
            this.cboActeurs.FormattingEnabled = true;
            this.cboActeurs.Location = new System.Drawing.Point(242, 77);
            this.cboActeurs.Name = "cboActeurs";
            this.cboActeurs.Size = new System.Drawing.Size(435, 24);
            this.cboActeurs.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(206, 185);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(164, 59);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(472, 185);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(164, 59);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouterNouveauActeur
            // 
            this.btnAjouterNouveauActeur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAjouterNouveauActeur.Location = new System.Drawing.Point(344, 386);
            this.btnAjouterNouveauActeur.Name = "btnAjouterNouveauActeur";
            this.btnAjouterNouveauActeur.Size = new System.Drawing.Size(234, 63);
            this.btnAjouterNouveauActeur.TabIndex = 3;
            this.btnAjouterNouveauActeur.Text = "Ajouter Nouveau Acteur";
            this.btnAjouterNouveauActeur.UseVisualStyleBackColor = false;
            this.btnAjouterNouveauActeur.Click += new System.EventHandler(this.btnAjouterNouveauActeur_Click);
            // 
            // SelectionActeurDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.btnAjouterNouveauActeur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboActeurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionActeurDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionActeurDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActeurs;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterNouveauActeur;
    }
}