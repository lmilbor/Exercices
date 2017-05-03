namespace ADO
{
    partial class FormSaisieProduit
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblQteUnitaire = new System.Windows.Forms.Label();
            this.lblPrixUnitaire = new System.Windows.Forms.Label();
            this.lblUniteEnStock = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.mtbUniteEnStock = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrixUnitaire = new System.Windows.Forms.MaskedTextBox();
            this.tbQteUnitaire = new System.Windows.Forms.TextBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbFournisseur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(103, 2);
            this.tbNom.MaxLength = 40;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(241, 20);
            this.tbNom.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 40);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 7;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblQteUnitaire
            // 
            this.lblQteUnitaire.AutoSize = true;
            this.lblQteUnitaire.Location = new System.Drawing.Point(12, 68);
            this.lblQteUnitaire.Name = "lblQteUnitaire";
            this.lblQteUnitaire.Size = new System.Drawing.Size(84, 13);
            this.lblQteUnitaire.TabIndex = 8;
            this.lblQteUnitaire.Text = "Quantité unitaire";
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.AutoSize = true;
            this.lblPrixUnitaire.Location = new System.Drawing.Point(12, 98);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(61, 13);
            this.lblPrixUnitaire.TabIndex = 9;
            this.lblPrixUnitaire.Text = "Prix unitaire";
            // 
            // lblUniteEnStock
            // 
            this.lblUniteEnStock.AutoSize = true;
            this.lblUniteEnStock.Location = new System.Drawing.Point(12, 130);
            this.lblUniteEnStock.Name = "lblUniteEnStock";
            this.lblUniteEnStock.Size = new System.Drawing.Size(81, 13);
            this.lblUniteEnStock.TabIndex = 10;
            this.lblUniteEnStock.Text = "Unités en stock";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(12, 164);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(61, 13);
            this.lblFournisseur.TabIndex = 11;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(175, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(269, 223);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // mtbUniteEnStock
            // 
            this.mtbUniteEnStock.Location = new System.Drawing.Point(103, 130);
            this.mtbUniteEnStock.Mask = "0000";
            this.mtbUniteEnStock.Name = "mtbUniteEnStock";
            this.mtbUniteEnStock.Size = new System.Drawing.Size(62, 20);
            this.mtbUniteEnStock.TabIndex = 16;
            // 
            // mtbPrixUnitaire
            // 
            this.mtbPrixUnitaire.Location = new System.Drawing.Point(103, 92);
            this.mtbPrixUnitaire.Mask = "0000.00";
            this.mtbPrixUnitaire.Name = "mtbPrixUnitaire";
            this.mtbPrixUnitaire.Size = new System.Drawing.Size(62, 20);
            this.mtbPrixUnitaire.TabIndex = 17;
            // 
            // tbQteUnitaire
            // 
            this.tbQteUnitaire.Location = new System.Drawing.Point(103, 61);
            this.tbQteUnitaire.Name = "tbQteUnitaire";
            this.tbQteUnitaire.Size = new System.Drawing.Size(62, 20);
            this.tbQteUnitaire.TabIndex = 18;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(103, 34);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 19;
            // 
            // cbFournisseur
            // 
            this.cbFournisseur.FormattingEnabled = true;
            this.cbFournisseur.Location = new System.Drawing.Point(103, 161);
            this.cbFournisseur.Name = "cbFournisseur";
            this.cbFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbFournisseur.TabIndex = 20;
            // 
            // FormSaisieProduit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(384, 266);
            this.ControlBox = false;
            this.Controls.Add(this.cbFournisseur);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.tbQteUnitaire);
            this.Controls.Add(this.mtbPrixUnitaire);
            this.Controls.Add(this.mtbUniteEnStock);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblUniteEnStock);
            this.Controls.Add(this.lblPrixUnitaire);
            this.Controls.Add(this.lblQteUnitaire);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 305);
            this.MinimumSize = new System.Drawing.Size(400, 305);
            this.Name = "FormSaisieProduit";
            this.Text = "FormSaisieProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblQteUnitaire;
        private System.Windows.Forms.Label lblPrixUnitaire;
        private System.Windows.Forms.Label lblUniteEnStock;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.MaskedTextBox mtbUniteEnStock;
        private System.Windows.Forms.MaskedTextBox mtbPrixUnitaire;
        private System.Windows.Forms.TextBox tbQteUnitaire;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ComboBox cbFournisseur;
    }
}