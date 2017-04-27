namespace ADO
{
    partial class FormFournisseurs
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
            this.dgvListFournisseurs = new System.Windows.Forms.DataGridView();
            this.cbListPays = new System.Windows.Forms.ComboBox();
            this.lblNbProduitsFournisseur = new System.Windows.Forms.Label();
            this.lblresNbProduitsFournisseur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListFournisseurs
            // 
            this.dgvListFournisseurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFournisseurs.Location = new System.Drawing.Point(0, 28);
            this.dgvListFournisseurs.Name = "dgvListFournisseurs";
            this.dgvListFournisseurs.Size = new System.Drawing.Size(869, 459);
            this.dgvListFournisseurs.TabIndex = 0;
            // 
            // cbListPays
            // 
            this.cbListPays.FormattingEnabled = true;
            this.cbListPays.Location = new System.Drawing.Point(301, 1);
            this.cbListPays.Name = "cbListPays";
            this.cbListPays.Size = new System.Drawing.Size(92, 21);
            this.cbListPays.TabIndex = 2;
            // 
            // lblNbProduitsFournisseur
            // 
            this.lblNbProduitsFournisseur.AutoSize = true;
            this.lblNbProduitsFournisseur.Location = new System.Drawing.Point(53, 7);
            this.lblNbProduitsFournisseur.Name = "lblNbProduitsFournisseur";
            this.lblNbProduitsFournisseur.Size = new System.Drawing.Size(242, 13);
            this.lblNbProduitsFournisseur.TabIndex = 3;
            this.lblNbProduitsFournisseur.Text = " produits fournis par l’ensemble les fournisseurs de";
            // 
            // lblresNbProduitsFournisseur
            // 
            this.lblresNbProduitsFournisseur.AutoSize = true;
            this.lblresNbProduitsFournisseur.Location = new System.Drawing.Point(34, 7);
            this.lblresNbProduitsFournisseur.Name = "lblresNbProduitsFournisseur";
            this.lblresNbProduitsFournisseur.Size = new System.Drawing.Size(13, 13);
            this.lblresNbProduitsFournisseur.TabIndex = 4;
            this.lblresNbProduitsFournisseur.Text = "0";
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.lblresNbProduitsFournisseur);
            this.Controls.Add(this.lblNbProduitsFournisseur);
            this.Controls.Add(this.cbListPays);
            this.Controls.Add(this.dgvListFournisseurs);
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListFournisseurs;
        private System.Windows.Forms.ComboBox cbListPays;
        private System.Windows.Forms.Label lblNbProduitsFournisseur;
        private System.Windows.Forms.Label lblresNbProduitsFournisseur;
    }
}