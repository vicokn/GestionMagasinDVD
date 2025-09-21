namespace GestionMagasinDVD
{
    partial class FormTableauDeBord
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRetoursPrevus = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridClientEnRetard = new System.Windows.Forms.DataGridView();
            this.btnReleveRetard = new System.Windows.Forms.Button();
            this.dataGridViewDerniersEmprunts = new System.Windows.Forms.DataGridView();
            this.btnReleveSortis = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEnvoyerRappels = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnVoirStockHTML = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNouvelEmprunt = new System.Windows.Forms.Button();
            this.btnRetourDVD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetoursPrevus)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientEnRetard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerniersEmprunts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 139);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionMagasinDVD.Properties.Resources.storage_15479725;
            this.pictureBox1.Location = new System.Drawing.Point(23, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DVD dispo:";
            // 
            // dataGridViewRetoursPrevus
            // 
            this.dataGridViewRetoursPrevus.AllowUserToAddRows = false;
            this.dataGridViewRetoursPrevus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRetoursPrevus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetoursPrevus.Location = new System.Drawing.Point(554, 428);
            this.dataGridViewRetoursPrevus.Name = "dataGridViewRetoursPrevus";
            this.dataGridViewRetoursPrevus.ReadOnly = true;
            this.dataGridViewRetoursPrevus.RowHeadersWidth = 51;
            this.dataGridViewRetoursPrevus.RowTemplate.Height = 24;
            this.dataGridViewRetoursPrevus.Size = new System.Drawing.Size(754, 241);
            this.dataGridViewRetoursPrevus.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.dataGridClientEnRetard);
            this.panel5.Controls.Add(this.btnReleveRetard);
            this.panel5.Controls.Add(this.dataGridViewDerniersEmprunts);
            this.panel5.Controls.Add(this.btnReleveSortis);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.btnEnvoyerRappels);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.btnVoirStockHTML);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.dataGridViewRetoursPrevus);
            this.panel5.Controls.Add(this.btnNouvelEmprunt);
            this.panel5.Controls.Add(this.btnRetourDVD);
            this.panel5.Location = new System.Drawing.Point(12, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1703, 894);
            this.panel5.TabIndex = 4;
            // 
            // dataGridClientEnRetard
            // 
            this.dataGridClientEnRetard.AllowUserToAddRows = false;
            this.dataGridClientEnRetard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientEnRetard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientEnRetard.Location = new System.Drawing.Point(110, 91);
            this.dataGridClientEnRetard.Name = "dataGridClientEnRetard";
            this.dataGridClientEnRetard.ReadOnly = true;
            this.dataGridClientEnRetard.RowHeadersWidth = 51;
            this.dataGridClientEnRetard.RowTemplate.Height = 24;
            this.dataGridClientEnRetard.Size = new System.Drawing.Size(618, 276);
            this.dataGridClientEnRetard.TabIndex = 18;
            // 
            // btnReleveRetard
            // 
            this.btnReleveRetard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReleveRetard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleveRetard.Location = new System.Drawing.Point(1412, 718);
            this.btnReleveRetard.Name = "btnReleveRetard";
            this.btnReleveRetard.Size = new System.Drawing.Size(279, 47);
            this.btnReleveRetard.TabIndex = 17;
            this.btnReleveRetard.Text = "Relevé DVD en retard";
            this.btnReleveRetard.UseVisualStyleBackColor = false;
            this.btnReleveRetard.Click += new System.EventHandler(this.btnReleveRetard_Click);
            // 
            // dataGridViewDerniersEmprunts
            // 
            this.dataGridViewDerniersEmprunts.AllowUserToAddRows = false;
            this.dataGridViewDerniersEmprunts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDerniersEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDerniersEmprunts.Location = new System.Drawing.Point(982, 80);
            this.dataGridViewDerniersEmprunts.Name = "dataGridViewDerniersEmprunts";
            this.dataGridViewDerniersEmprunts.ReadOnly = true;
            this.dataGridViewDerniersEmprunts.RowHeadersWidth = 51;
            this.dataGridViewDerniersEmprunts.RowTemplate.Height = 24;
            this.dataGridViewDerniersEmprunts.Size = new System.Drawing.Size(597, 276);
            this.dataGridViewDerniersEmprunts.TabIndex = 7;
            // 
            // btnReleveSortis
            // 
            this.btnReleveSortis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReleveSortis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleveSortis.Location = new System.Drawing.Point(1114, 718);
            this.btnReleveSortis.Name = "btnReleveSortis";
            this.btnReleveSortis.Size = new System.Drawing.Size(263, 47);
            this.btnReleveSortis.TabIndex = 16;
            this.btnReleveSortis.Text = "Relevé DVD sortis";
            this.btnReleveSortis.UseVisualStyleBackColor = false;
            this.btnReleveSortis.Click += new System.EventHandler(this.btnReleveSortis_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(978, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(267, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Derniers emprunts enregistrés";
            // 
            // btnEnvoyerRappels
            // 
            this.btnEnvoyerRappels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEnvoyerRappels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerRappels.Location = new System.Drawing.Point(570, 718);
            this.btnEnvoyerRappels.Name = "btnEnvoyerRappels";
            this.btnEnvoyerRappels.Size = new System.Drawing.Size(214, 47);
            this.btnEnvoyerRappels.TabIndex = 15;
            this.btnEnvoyerRappels.Text = "Envoyer rappels";
            this.btnEnvoyerRappels.UseVisualStyleBackColor = false;
            this.btnEnvoyerRappels.Click += new System.EventHandler(this.btnEnvoyerRappels_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(765, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(313, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Retours prévus aujourd’hui / demain";
            // 
            // btnVoirStockHTML
            // 
            this.btnVoirStockHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVoirStockHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirStockHTML.Location = new System.Drawing.Point(861, 718);
            this.btnVoirStockHTML.Name = "btnVoirStockHTML";
            this.btnVoirStockHTML.Size = new System.Drawing.Size(217, 47);
            this.btnVoirStockHTML.TabIndex = 14;
            this.btnVoirStockHTML.Text = "Voir Stock en HTML";
            this.btnVoirStockHTML.UseVisualStyleBackColor = false;
            this.btnVoirStockHTML.Click += new System.EventHandler(this.btnVoirStockHTML_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(106, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Clients en retard";
            // 
            // btnNouvelEmprunt
            // 
            this.btnNouvelEmprunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNouvelEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelEmprunt.Location = new System.Drawing.Point(22, 718);
            this.btnNouvelEmprunt.Name = "btnNouvelEmprunt";
            this.btnNouvelEmprunt.Size = new System.Drawing.Size(227, 47);
            this.btnNouvelEmprunt.TabIndex = 8;
            this.btnNouvelEmprunt.Text = "Nouvel emprunt";
            this.btnNouvelEmprunt.UseVisualStyleBackColor = false;
            this.btnNouvelEmprunt.Click += new System.EventHandler(this.btnNouvelEmprunt_Click);
            // 
            // btnRetourDVD
            // 
            this.btnRetourDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRetourDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourDVD.Location = new System.Drawing.Point(299, 718);
            this.btnRetourDVD.Name = "btnRetourDVD";
            this.btnRetourDVD.Size = new System.Drawing.Size(193, 47);
            this.btnRetourDVD.TabIndex = 9;
            this.btnRetourDVD.Text = "Retour DVD";
            this.btnRetourDVD.UseVisualStyleBackColor = false;
            this.btnRetourDVD.Click += new System.EventHandler(this.btnRetourDVD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(286, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 139);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionMagasinDVD.Properties.Resources.music_16226642;
            this.pictureBox2.Location = new System.Drawing.Point(23, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "DVD en pret:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(566, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 139);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestionMagasinDVD.Properties.Resources.video_16010793;
            this.pictureBox3.Location = new System.Drawing.Point(23, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "DVD retard de retour";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(831, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 139);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionMagasinDVD.Properties.Resources.vecteezy_illustration_of_give_money_icon_png_on_transparent_background_14455861;
            this.pictureBox4.Location = new System.Drawing.Point(10, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montant total amende en attente:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(1173, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 139);
            this.panel7.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GestionMagasinDVD.Properties.Resources.vecteezy_a_black_and_white_silhouette_of_a_man_in_a_suit_49671724;
            this.pictureBox6.Location = new System.Drawing.Point(6, 51);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Clients en retard de cotisation";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel8.Controls.Add(this.pictureBox7);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(1482, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 139);
            this.panel8.TabIndex = 13;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestionMagasinDVD.Properties.Resources.vecteezy_3d_avatar_icon_18742608;
            this.pictureBox7.Location = new System.Drawing.Point(23, 51);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(78, 71);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Clients en retard de rentrée";
            // 
            // FormTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "FormTableauDeBord";
            this.Size = new System.Drawing.Size(2090, 1309);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetoursPrevus)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientEnRetard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerniersEmprunts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewRetoursPrevus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNouvelEmprunt;
        private System.Windows.Forms.Button btnRetourDVD;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewDerniersEmprunts;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnVoirStockHTML;
        private System.Windows.Forms.Button btnEnvoyerRappels;
        private System.Windows.Forms.Button btnReleveRetard;
        private System.Windows.Forms.Button btnReleveSortis;
        private System.Windows.Forms.DataGridView dataGridClientEnRetard;
    }
}
