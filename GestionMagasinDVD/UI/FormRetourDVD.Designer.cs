namespace GestionMagasinDVD.UI
{
    partial class FormRetourDVD
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
            this.cbEmprunts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDVD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emprunt";
            // 
            // cbEmprunts
            // 
            this.cbEmprunts.FormattingEnabled = true;
            this.cbEmprunts.Location = new System.Drawing.Point(278, 79);
            this.cbEmprunts.Name = "cbEmprunts";
            this.cbEmprunts.Size = new System.Drawing.Size(247, 24);
            this.cbEmprunts.TabIndex = 1;
            this.cbEmprunts.SelectedIndexChanged += new System.EventHandler(this.cbEmprunts_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(369, 140);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "DVD";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(369, 201);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(0, 16);
            this.lblDVD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date retour prévue";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(369, 256);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(0, 16);
            this.lblDateRetour.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(115, 367);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(144, 46);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(352, 367);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(144, 46);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormRetourDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDVD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmprunts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRetourDVD";
            this.Text = "FormRetourDVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmprunts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}