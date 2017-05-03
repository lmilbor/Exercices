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
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.lblProduits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListFournisseurs
            // 
            this.dgvListFournisseurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFournisseurs.Location = new System.Drawing.Point(4, 28);
            this.dgvListFournisseurs.Name = "dgvListFournisseurs";
            this.dgvListFournisseurs.Size = new System.Drawing.Size(864, 96);
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
            // dgvProduits
            // 
            this.dgvProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(4, 161);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.Size = new System.Drawing.Size(864, 321);
            this.dgvProduits.TabIndex = 5;
            // 
            // lblProduits
            // 
            this.lblProduits.AutoSize = true;
            this.lblProduits.Location = new System.Drawing.Point(12, 136);
            this.lblProduits.Name = "lblProduits";
            this.lblProduits.Size = new System.Drawing.Size(45, 13);
            this.lblProduits.TabIndex = 6;
            this.lblProduits.Text = "Produits";
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 485);
            this.Controls.Add(this.lblProduits);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.lblresNbProduitsFournisseur);
            this.Controls.Add(this.lblNbProduitsFournisseur);
            this.Controls.Add(this.cbListPays);
            this.Controls.Add(this.dgvListFournisseurs);
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFournisseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListFournisseurs;
        private System.Windows.Forms.ComboBox cbListPays;
        private System.Windows.Forms.Label lblNbProduitsFournisseur;
        private System.Windows.Forms.Label lblresNbProduitsFournisseur;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Label lblProduits;
    }
}