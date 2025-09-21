namespace GestionMagasinDVD.UI
{
    partial class GestionDVD
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
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.cboRealisateur = new System.Windows.Forms.ComboBox();
            this.gridActeurs = new System.Windows.Forms.DataGridView();
            this.btnAjouterActeur = new System.Windows.Forms.Button();
            this.btnRetirerActeur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterRealisateur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(188, 56);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(190, 22);
            this.txtTitre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Année de sortie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix location\t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Disponible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Réalisateur";
            // 
            // numAnnee
            // 
            this.numAnnee.Location = new System.Drawing.Point(189, 117);
            this.numAnnee.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(189, 22);
            this.numAnnee.TabIndex = 6;
            this.numAnnee.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numPrix
            // 
            this.numPrix.DecimalPlaces = 2;
            this.numPrix.Location = new System.Drawing.Point(189, 166);
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(189, 22);
            this.numPrix.TabIndex = 7;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(242, 212);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(49, 20);
            this.chkDisponible.TabIndex = 8;
            this.chkDisponible.Text = "Oui";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // cboRealisateur
            // 
            this.cboRealisateur.FormattingEnabled = true;
            this.cboRealisateur.Location = new System.Drawing.Point(188, 268);
            this.cboRealisateur.Name = "cboRealisateur";
            this.cboRealisateur.Size = new System.Drawing.Size(246, 24);
            this.cboRealisateur.TabIndex = 9;
            // 
            // gridActeurs
            // 
            this.gridActeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActeurs.Location = new System.Drawing.Point(43, 359);
            this.gridActeurs.Name = "gridActeurs";
            this.gridActeurs.RowHeadersWidth = 51;
            this.gridActeurs.RowTemplate.Height = 24;
            this.gridActeurs.Size = new System.Drawing.Size(559, 172);
            this.gridActeurs.TabIndex = 10;
            // 
            // btnAjouterActeur
            // 
            this.btnAjouterActeur.Location = new System.Drawing.Point(666, 398);
            this.btnAjouterActeur.Name = "btnAjouterActeur";
            this.btnAjouterActeur.Size = new System.Drawing.Size(243, 31);
            this.btnAjouterActeur.TabIndex = 11;
            this.btnAjouterActeur.Text = "Ajouter acteur";
            this.btnAjouterActeur.UseVisualStyleBackColor = true;
            this.btnAjouterActeur.Click += new System.EventHandler(this.btnAjouterActeur_Click);
            // 
            // btnRetirerActeur
            // 
            this.btnRetirerActeur.Location = new System.Drawing.Point(666, 463);
            this.btnRetirerActeur.Name = "btnRetirerActeur";
            this.btnRetirerActeur.Size = new System.Drawing.Size(243, 28);
            this.btnRetirerActeur.TabIndex = 12;
            this.btnRetirerActeur.Text = "Supprimer acteur";
            this.btnRetirerActeur.UseVisualStyleBackColor = true;
            this.btnRetirerActeur.Click += new System.EventHandler(this.btnRetirerActeur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Acteurs principaux";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEnregistrer.Location = new System.Drawing.Point(214, 605);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(164, 55);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAnnuler.Location = new System.Drawing.Point(532, 605);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(164, 55);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouterRealisateur
            // 
            this.btnAjouterRealisateur.Location = new System.Drawing.Point(666, 268);
            this.btnAjouterRealisateur.Name = "btnAjouterRealisateur";
            this.btnAjouterRealisateur.Size = new System.Drawing.Size(243, 24);
            this.btnAjouterRealisateur.TabIndex = 16;
            this.btnAjouterRealisateur.Text = "Ajouter Réalisateur";
            this.btnAjouterRealisateur.UseVisualStyleBackColor = true;
            this.btnAjouterRealisateur.Click += new System.EventHandler(this.btnAjouterRealisateur_Click);
            // 
            // GestionDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(996, 745);
            this.Controls.Add(this.btnAjouterRealisateur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRetirerActeur);
            this.Controls.Add(this.btnAjouterActeur);
            this.Controls.Add(this.gridActeurs);
            this.Controls.Add(this.cboRealisateur);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.numPrix);
            this.Controls.Add(this.numAnnee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDVD";
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActeurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAnnee;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.ComboBox cboRealisateur;
        private System.Windows.Forms.DataGridView gridActeurs;
        private System.Windows.Forms.Button btnAjouterActeur;
        private System.Windows.Forms.Button btnRetirerActeur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterRealisateur;
    }
}