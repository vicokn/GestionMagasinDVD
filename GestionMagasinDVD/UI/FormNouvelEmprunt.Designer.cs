namespace GestionMagasinDVD.UI
{
    partial class FormNouvelEmprunt
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.cbDVDs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(280, 42);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(219, 24);
            this.cbClients.TabIndex = 1;
            // 
            // cbDVDs
            // 
            this.cbDVDs.FormattingEnabled = true;
            this.cbDVDs.Location = new System.Drawing.Point(273, 134);
            this.cbDVDs.Name = "cbDVDs";
            this.cbDVDs.Size = new System.Drawing.Size(230, 24);
            this.cbDVDs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DVD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date retour prévue";
            // 
            // dtpRetour
            // 
            this.dtpRetour.Location = new System.Drawing.Point(280, 247);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(223, 22);
            this.dtpRetour.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(102, 332);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(154, 39);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(349, 332);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(154, 39);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // FormNouvelEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 412);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dtpRetour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDVDs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNouvelEmprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNouvelEmprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.ComboBox cbDVDs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRetour;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}