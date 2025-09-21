namespace GestionMagasinDVD.UI
{
    partial class FormAlertesRappels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNbRappels = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRappels = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnvoyerRappel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRappels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(43, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1723, 387);
            this.panel1.TabIndex = 3;
            // 
            // labelNbRappels
            // 
            this.labelNbRappels.AutoSize = true;
            this.labelNbRappels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbRappels.Location = new System.Drawing.Point(629, 81);
            this.labelNbRappels.Name = "labelNbRappels";
            this.labelNbRappels.Size = new System.Drawing.Size(0, 20);
            this.labelNbRappels.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnEnvoyerRappel);
            this.panel2.Controls.Add(this.labelNbRappels);
            this.panel2.Controls.Add(this.dataGridViewRappels);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(43, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1723, 486);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewRappels
            // 
            this.dataGridViewRappels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRappels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRappels.Location = new System.Drawing.Point(319, 134);
            this.dataGridViewRappels.Name = "dataGridViewRappels";
            this.dataGridViewRappels.RowHeadersWidth = 51;
            this.dataGridViewRappels.RowTemplate.Height = 24;
            this.dataGridViewRappels.Size = new System.Drawing.Size(753, 327);
            this.dataGridViewRappels.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liste des rappels";
            // 
            // btnEnvoyerRappel
            // 
            this.btnEnvoyerRappel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnvoyerRappel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerRappel.Location = new System.Drawing.Point(741, 34);
            this.btnEnvoyerRappel.Name = "btnEnvoyerRappel";
            this.btnEnvoyerRappel.Size = new System.Drawing.Size(225, 47);
            this.btnEnvoyerRappel.TabIndex = 30;
            this.btnEnvoyerRappel.Text = "Envoyer rappel";
            this.btnEnvoyerRappel.UseVisualStyleBackColor = false;
            this.btnEnvoyerRappel.Click += new System.EventHandler(this.btnEnvoyerRappel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionMagasinDVD.Properties.Resources.Alerte;
            this.pictureBox1.Location = new System.Drawing.Point(253, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormAlertesRappels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAlertesRappels";
            this.Size = new System.Drawing.Size(2090, 1309);
            this.Load += new System.EventHandler(this.FormAlertesRappels_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRappels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNbRappels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewRappels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnvoyerRappel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
