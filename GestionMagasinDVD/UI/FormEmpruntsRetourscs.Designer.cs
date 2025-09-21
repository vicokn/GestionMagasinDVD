namespace GestionMagasinDVD.UI
{
    partial class FormEmpruntsRetourscs
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtpRetourPrevu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDVDs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNbRappels = new System.Windows.Forms.Label();
            this.btnEnregistrerEmprunt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnregistrerRetour = new System.Windows.Forms.Button();
            this.dgvEmpruntsEnCours = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpruntsEnCours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.dtpRetourPrevu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboDVDs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboClients);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNbRappels);
            this.panel1.Controls.Add(this.btnEnregistrerEmprunt);
            this.panel1.Location = new System.Drawing.Point(54, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1723, 387);
            this.panel1.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(619, 211);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 25);
            this.lblMessage.TabIndex = 37;
            // 
            // dtpRetourPrevu
            // 
            this.dtpRetourPrevu.Location = new System.Drawing.Point(633, 215);
            this.dtpRetourPrevu.Name = "dtpRetourPrevu";
            this.dtpRetourPrevu.Size = new System.Drawing.Size(232, 22);
            this.dtpRetourPrevu.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date retour prévue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "DVD:";
            // 
            // cboDVDs
            // 
            this.cboDVDs.FormattingEnabled = true;
            this.cboDVDs.Location = new System.Drawing.Point(630, 154);
            this.cboDVDs.Name = "cboDVDs";
            this.cboDVDs.Size = new System.Drawing.Size(244, 24);
            this.cboDVDs.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Client:";
            // 
            // cboClients
            // 
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(630, 97);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(244, 24);
            this.cboClients.TabIndex = 31;
            this.cboClients.SelectedIndexChanged += new System.EventHandler(this.cboClients_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nouvel emprunt";
            // 
            // labelNbRappels
            // 
            this.labelNbRappels.AutoSize = true;
            this.labelNbRappels.Location = new System.Drawing.Point(522, 57);
            this.labelNbRappels.Name = "labelNbRappels";
            this.labelNbRappels.Size = new System.Drawing.Size(0, 16);
            this.labelNbRappels.TabIndex = 29;
            // 
            // btnEnregistrerEmprunt
            // 
            this.btnEnregistrerEmprunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnregistrerEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerEmprunt.Location = new System.Drawing.Point(739, 317);
            this.btnEnregistrerEmprunt.Name = "btnEnregistrerEmprunt";
            this.btnEnregistrerEmprunt.Size = new System.Drawing.Size(225, 47);
            this.btnEnregistrerEmprunt.TabIndex = 26;
            this.btnEnregistrerEmprunt.Text = "Enregistrer Emprunt";
            this.btnEnregistrerEmprunt.UseVisualStyleBackColor = false;
            this.btnEnregistrerEmprunt.Click += new System.EventHandler(this.btnEnregistrerEmprunt_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnEnregistrerRetour);
            this.panel2.Controls.Add(this.dgvEmpruntsEnCours);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(54, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1723, 387);
            this.panel2.TabIndex = 5;
            // 
            // btnEnregistrerRetour
            // 
            this.btnEnregistrerRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnregistrerRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerRetour.Location = new System.Drawing.Point(1164, 167);
            this.btnEnregistrerRetour.Name = "btnEnregistrerRetour";
            this.btnEnregistrerRetour.Size = new System.Drawing.Size(225, 47);
            this.btnEnregistrerRetour.TabIndex = 35;
            this.btnEnregistrerRetour.Text = "Enregistrer Retour";
            this.btnEnregistrerRetour.UseVisualStyleBackColor = false;
            this.btnEnregistrerRetour.Click += new System.EventHandler(this.btnEnregistrerRetour_Click_1);
            // 
            // dgvEmpruntsEnCours
            // 
            this.dgvEmpruntsEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpruntsEnCours.Location = new System.Drawing.Point(263, 53);
            this.dgvEmpruntsEnCours.Name = "dgvEmpruntsEnCours";
            this.dgvEmpruntsEnCours.RowHeadersWidth = 51;
            this.dgvEmpruntsEnCours.RowTemplate.Height = 24;
            this.dgvEmpruntsEnCours.Size = new System.Drawing.Size(708, 245);
            this.dgvEmpruntsEnCours.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Emprunts en cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Retours";
            // 
            // FormEmpruntsRetourscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpruntsRetourscs";
            this.Size = new System.Drawing.Size(2090, 1309);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpruntsEnCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNbRappels;
        private System.Windows.Forms.Button btnEnregistrerEmprunt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDVDs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRetourPrevu;
        private System.Windows.Forms.DataGridView dgvEmpruntsEnCours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnregistrerRetour;
        private System.Windows.Forms.Label lblMessage;
    }
}
