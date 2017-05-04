namespace CollectionsBD
{
    partial class FormBibliothèqueDeBDs
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
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.btnFiltreAnnée = new System.Windows.Forms.Button();
            this.btnAddAuteur = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.mtbAnnéeDébut = new System.Windows.Forms.MaskedTextBox();
            this.mtbAnnéeFin = new System.Windows.Forms.MaskedTextBox();
            this.lblAnnéeDébut = new System.Windows.Forms.Label();
            this.lblAnnéeFin = new System.Windows.Forms.Label();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCollections
            // 
            this.dgvCollections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(12, 66);
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.Size = new System.Drawing.Size(318, 541);
            this.dgvCollections.TabIndex = 0;
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(345, 66);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(267, 541);
            this.dgvAlbums.TabIndex = 1;
            // 
            // btnFiltreAnnée
            // 
            this.btnFiltreAnnée.Location = new System.Drawing.Point(144, 21);
            this.btnFiltreAnnée.Name = "btnFiltreAnnée";
            this.btnFiltreAnnée.Size = new System.Drawing.Size(94, 23);
            this.btnFiltreAnnée.TabIndex = 2;
            this.btnFiltreAnnée.Text = "Filtrer par année";
            this.btnFiltreAnnée.UseVisualStyleBackColor = true;
            // 
            // btnAddAuteur
            // 
            this.btnAddAuteur.Location = new System.Drawing.Point(291, 31);
            this.btnAddAuteur.Name = "btnAddAuteur";
            this.btnAddAuteur.Size = new System.Drawing.Size(103, 23);
            this.btnAddAuteur.TabIndex = 3;
            this.btnAddAuteur.Text = "Ajouter un auteur";
            this.btnAddAuteur.UseVisualStyleBackColor = true;
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(430, 21);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(100, 23);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Ajouter un album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            // 
            // mtbAnnéeDébut
            // 
            this.mtbAnnéeDébut.Location = new System.Drawing.Point(12, 12);
            this.mtbAnnéeDébut.Mask = "0000";
            this.mtbAnnéeDébut.Name = "mtbAnnéeDébut";
            this.mtbAnnéeDébut.Size = new System.Drawing.Size(37, 20);
            this.mtbAnnéeDébut.TabIndex = 5;
            // 
            // mtbAnnéeFin
            // 
            this.mtbAnnéeFin.Location = new System.Drawing.Point(12, 38);
            this.mtbAnnéeFin.Mask = "0000";
            this.mtbAnnéeFin.Name = "mtbAnnéeFin";
            this.mtbAnnéeFin.Size = new System.Drawing.Size(37, 20);
            this.mtbAnnéeFin.TabIndex = 6;
            // 
            // lblAnnéeDébut
            // 
            this.lblAnnéeDébut.AutoSize = true;
            this.lblAnnéeDébut.Location = new System.Drawing.Point(55, 15);
            this.lblAnnéeDébut.Name = "lblAnnéeDébut";
            this.lblAnnéeDébut.Size = new System.Drawing.Size(83, 13);
            this.lblAnnéeDébut.TabIndex = 7;
            this.lblAnnéeDébut.Text = "Année de début";
            // 
            // lblAnnéeFin
            // 
            this.lblAnnéeFin.AutoSize = true;
            this.lblAnnéeFin.Location = new System.Drawing.Point(55, 41);
            this.lblAnnéeFin.Name = "lblAnnéeFin";
            this.lblAnnéeFin.Size = new System.Drawing.Size(67, 13);
            this.lblAnnéeFin.TabIndex = 8;
            this.lblAnnéeFin.Text = "Année de fin";
            // 
            // tbAuteur
            // 
            this.tbAuteur.Location = new System.Drawing.Point(291, 5);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.Size = new System.Drawing.Size(100, 20);
            this.tbAuteur.TabIndex = 9;
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(557, 21);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(105, 23);
            this.btnToUpper.TabIndex = 10;
            this.btnToUpper.Text = "Titre en majuscule";
            this.btnToUpper.UseVisualStyleBackColor = true;
            // 
            // lbAlbum
            // 
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.Location = new System.Drawing.Point(638, 71);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(316, 524);
            this.lbAlbum.TabIndex = 11;
            // 
            // FormBibliothèqueDeBDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 619);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.tbAuteur);
            this.Controls.Add(this.lblAnnéeFin);
            this.Controls.Add(this.lblAnnéeDébut);
            this.Controls.Add(this.mtbAnnéeFin);
            this.Controls.Add(this.mtbAnnéeDébut);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnAddAuteur);
            this.Controls.Add(this.btnFiltreAnnée);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.dgvCollections);
            this.Name = "FormBibliothèqueDeBDs";
            this.Text = "Bibliothèque de BDs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCollections;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.Button btnFiltreAnnée;
        private System.Windows.Forms.Button btnAddAuteur;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.MaskedTextBox mtbAnnéeDébut;
        private System.Windows.Forms.MaskedTextBox mtbAnnéeFin;
        private System.Windows.Forms.Label lblAnnéeDébut;
        private System.Windows.Forms.Label lblAnnéeFin;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.ListBox lbAlbum;
    }
}

