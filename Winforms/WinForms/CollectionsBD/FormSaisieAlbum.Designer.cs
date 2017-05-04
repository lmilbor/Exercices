namespace CollectionsBD
{
    partial class FormSaisieAlbum
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
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.mtbAnnée = new System.Windows.Forms.MaskedTextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblAnnée = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(12, 23);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 0;
            // 
            // tbAuteur
            // 
            this.tbAuteur.Location = new System.Drawing.Point(12, 75);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.Size = new System.Drawing.Size(100, 20);
            this.tbAuteur.TabIndex = 1;
            // 
            // mtbAnnée
            // 
            this.mtbAnnée.Location = new System.Drawing.Point(12, 130);
            this.mtbAnnée.Mask = "0000";
            this.mtbAnnée.Name = "mtbAnnée";
            this.mtbAnnée.Size = new System.Drawing.Size(36, 20);
            this.mtbAnnée.TabIndex = 2;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(9, 7);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Titre";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(9, 59);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(38, 13);
            this.lblAuteur.TabIndex = 4;
            this.lblAuteur.Text = "Auteur";
            // 
            // lblAnnée
            // 
            this.lblAnnée.AutoSize = true;
            this.lblAnnée.Location = new System.Drawing.Point(9, 114);
            this.lblAnnée.Name = "lblAnnée";
            this.lblAnnée.Size = new System.Drawing.Size(38, 13);
            this.lblAnnée.TabIndex = 5;
            this.lblAnnée.Text = "Année";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Valider";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAnnuler.Location = new System.Drawing.Point(93, 173);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormSaisieAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 211);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAnnée);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.mtbAnnée);
            this.Controls.Add(this.tbAuteur);
            this.Controls.Add(this.tbTitre);
            this.MaximumSize = new System.Drawing.Size(200, 250);
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "FormSaisieAlbum";
            this.Text = "FormSaisieAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.MaskedTextBox mtbAnnée;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblAnnée;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}