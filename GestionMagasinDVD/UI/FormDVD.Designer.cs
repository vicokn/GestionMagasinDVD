namespace GestionMagasinDVD
{
    partial class FormDVD
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDVDs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimerDVD = new System.Windows.Forms.Button();
            this.btnModifierDVD = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnAjouterDVD = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVDs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDVDs
            // 
            this.dataGridViewDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDVDs.Location = new System.Drawing.Point(472, 80);
            this.dataGridViewDVDs.Name = "dataGridViewDVDs";
            this.dataGridViewDVDs.RowHeadersWidth = 51;
            this.dataGridViewDVDs.RowTemplate.Height = 24;
            this.dataGridViewDVDs.Size = new System.Drawing.Size(721, 290);
            this.dataGridViewDVDs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des DVD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dataGridViewDVDs);
            this.panel1.Controls.Add(this.btnSupprimerDVD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModifierDVD);
            this.panel1.Controls.Add(this.txtRecherche);
            this.panel1.Controls.Add(this.btnAjouterDVD);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Location = new System.Drawing.Point(92, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 387);
            this.panel1.TabIndex = 4;
            // 
            // btnSupprimerDVD
            // 
            this.btnSupprimerDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSupprimerDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerDVD.Location = new System.Drawing.Point(112, 280);
            this.btnSupprimerDVD.Name = "btnSupprimerDVD";
            this.btnSupprimerDVD.Size = new System.Drawing.Size(225, 47);
            this.btnSupprimerDVD.TabIndex = 27;
            this.btnSupprimerDVD.Text = "Supprimer";
            this.btnSupprimerDVD.UseVisualStyleBackColor = false;
            this.btnSupprimerDVD.Click += new System.EventHandler(this.btnSupprimerDVD_Click);
            // 
            // btnModifierDVD
            // 
            this.btnModifierDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifierDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierDVD.Location = new System.Drawing.Point(112, 179);
            this.btnModifierDVD.Name = "btnModifierDVD";
            this.btnModifierDVD.Size = new System.Drawing.Size(225, 47);
            this.btnModifierDVD.TabIndex = 26;
            this.btnModifierDVD.Text = "Modifier";
            this.btnModifierDVD.UseVisualStyleBackColor = false;
            this.btnModifierDVD.Click += new System.EventHandler(this.btnModifierDVD_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(576, 40);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(256, 22);
            this.txtRecherche.TabIndex = 23;
            // 
            // btnAjouterDVD
            // 
            this.btnAjouterDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAjouterDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDVD.Location = new System.Drawing.Point(112, 95);
            this.btnAjouterDVD.Name = "btnAjouterDVD";
            this.btnAjouterDVD.Size = new System.Drawing.Size(225, 47);
            this.btnAjouterDVD.TabIndex = 25;
            this.btnAjouterDVD.Text = "Ajouter";
            this.btnAjouterDVD.UseVisualStyleBackColor = false;
            this.btnAjouterDVD.Click += new System.EventHandler(this.btnAjouterDVD_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(938, 27);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(225, 47);
            this.btnRechercher.TabIndex = 24;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionMagasinDVD.Properties.Resources._8174269321_b5caf651eb_b;
            this.pictureBox1.Location = new System.Drawing.Point(245, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(107, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1560, 498);
            this.panel2.TabIndex = 6;
            // 
            // FormDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDVD";
            this.Size = new System.Drawing.Size(2090, 1309);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVDs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDVDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimerDVD;
        private System.Windows.Forms.Button btnModifierDVD;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnAjouterDVD;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}
