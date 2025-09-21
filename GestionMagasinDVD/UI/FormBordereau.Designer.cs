namespace GestionMagasinDVD.UI
{
    partial class FormBordereau
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
            this.lblClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDVD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateEmprunt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmende = new System.Windows.Forms.Label();
            this.btnExporter = new System.Windows.Forms.Button();
            this.brnFermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(315, 76);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DVD";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(315, 138);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(0, 16);
            this.lblDVD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date emprunt";
            // 
            // lblDateEmprunt
            // 
            this.lblDateEmprunt.AutoSize = true;
            this.lblDateEmprunt.Location = new System.Drawing.Point(315, 202);
            this.lblDateEmprunt.Name = "lblDateEmprunt";
            this.lblDateEmprunt.Size = new System.Drawing.Size(0, 16);
            this.lblDateEmprunt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date retour prévue";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(300, 262);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(0, 16);
            this.lblDateRetour.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Amende";
            // 
            // lblAmende
            // 
            this.lblAmende.AutoSize = true;
            this.lblAmende.Location = new System.Drawing.Point(315, 327);
            this.lblAmende.Name = "lblAmende";
            this.lblAmende.Size = new System.Drawing.Size(0, 16);
            this.lblAmende.TabIndex = 9;
            // 
            // btnExporter
            // 
            this.btnExporter.Location = new System.Drawing.Point(127, 380);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(132, 42);
            this.btnExporter.TabIndex = 10;
            this.btnExporter.Text = "Exporter";
            this.btnExporter.UseVisualStyleBackColor = true;
            this.btnExporter.Click += new System.EventHandler(this.btnExporter_Click);
            // 
            // brnFermer
            // 
            this.brnFermer.Location = new System.Drawing.Point(329, 380);
            this.brnFermer.Name = "brnFermer";
            this.brnFermer.Size = new System.Drawing.Size(132, 42);
            this.brnFermer.TabIndex = 11;
            this.brnFermer.Text = "Fermer";
            this.brnFermer.UseVisualStyleBackColor = true;
            this.brnFermer.Click += new System.EventHandler(this.brnFermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bordereau d\'emprunt";
            // 
            // FormBordereau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnFermer);
            this.Controls.Add(this.btnExporter);
            this.Controls.Add(this.lblAmende);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDateEmprunt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDVD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBordereau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBordereau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateEmprunt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmende;
        private System.Windows.Forms.Button btnExporter;
        private System.Windows.Forms.Button brnFermer;
        private System.Windows.Forms.Label label2;
    }
}