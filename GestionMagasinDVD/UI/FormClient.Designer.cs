namespace GestionMagasinDVD
{
    partial class FormClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnModifierClient);
            this.panel1.Controls.Add(this.txtRecherche);
            this.panel1.Controls.Add(this.btnSupprimerClient);
            this.panel1.Controls.Add(this.btnAjouterClient);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.dataGridViewClients);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 433);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerClient.Location = new System.Drawing.Point(29, 220);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(193, 55);
            this.btnSupprimerClient.TabIndex = 27;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierClient.Location = new System.Drawing.Point(29, 302);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(193, 51);
            this.btnModifierClient.TabIndex = 26;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(389, 63);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(256, 22);
            this.txtRecherche.TabIndex = 23;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.Location = new System.Drawing.Point(29, 148);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(193, 53);
            this.btnAjouterClient.TabIndex = 25;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(716, 50);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(225, 47);
            this.btnRechercher.TabIndex = 24;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(85, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1599, 449);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(330, 117);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(883, 284);
            this.dataGridViewClients.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::GestionMagasinDVD.Properties.Resources.pexels_shvetsa_3727509;
            this.pictureBox1.Location = new System.Drawing.Point(426, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClient";
            this.Size = new System.Drawing.Size(2090, 1309);
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
