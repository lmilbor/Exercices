namespace ADO
{
    partial class FormCommandes
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
            this.dgvListCommandesClient = new System.Windows.Forms.DataGridView();
            this.dgvSelectionCommande = new System.Windows.Forms.DataGridView();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblLigneCommande = new System.Windows.Forms.Label();
            this.tbIDClient = new System.Windows.Forms.TextBox();
            this.btnFiltrerIDClient = new System.Windows.Forms.Button();
            this.btnExporterXml = new System.Windows.Forms.Button();
            this.btnImporterXml = new System.Windows.Forms.Button();
            this.btnExporterXmlShort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandesClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectionCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCommandesClient
            // 
            this.dgvListCommandesClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCommandesClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCommandesClient.Location = new System.Drawing.Point(368, 42);
            this.dgvListCommandesClient.Name = "dgvListCommandesClient";
            this.dgvListCommandesClient.Size = new System.Drawing.Size(574, 441);
            this.dgvListCommandesClient.TabIndex = 0;
            // 
            // dgvSelectionCommande
            // 
            this.dgvSelectionCommande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSelectionCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectionCommande.Location = new System.Drawing.Point(1, 42);
            this.dgvSelectionCommande.Name = "dgvSelectionCommande";
            this.dgvSelectionCommande.Size = new System.Drawing.Size(361, 441);
            this.dgvSelectionCommande.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 26);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(65, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Commandes";
            // 
            // lblLigneCommande
            // 
            this.lblLigneCommande.AutoSize = true;
            this.lblLigneCommande.Location = new System.Drawing.Point(379, 26);
            this.lblLigneCommande.Name = "lblLigneCommande";
            this.lblLigneCommande.Size = new System.Drawing.Size(109, 13);
            this.lblLigneCommande.TabIndex = 3;
            this.lblLigneCommande.Text = "Ligne de Commandes";
            // 
            // tbIDClient
            // 
            this.tbIDClient.Location = new System.Drawing.Point(12, 3);
            this.tbIDClient.Name = "tbIDClient";
            this.tbIDClient.Size = new System.Drawing.Size(100, 20);
            this.tbIDClient.TabIndex = 4;
            this.tbIDClient.Text = "IDClient";
            // 
            // btnFiltrerIDClient
            // 
            this.btnFiltrerIDClient.Location = new System.Drawing.Point(118, 0);
            this.btnFiltrerIDClient.Name = "btnFiltrerIDClient";
            this.btnFiltrerIDClient.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrerIDClient.TabIndex = 5;
            this.btnFiltrerIDClient.Text = "Filtrer";
            this.btnFiltrerIDClient.UseVisualStyleBackColor = true;
            // 
            // btnExporterXml
            // 
            this.btnExporterXml.Location = new System.Drawing.Point(199, 0);
            this.btnExporterXml.Name = "btnExporterXml";
            this.btnExporterXml.Size = new System.Drawing.Size(105, 23);
            this.btnExporterXml.TabIndex = 6;
            this.btnExporterXml.Text = "Exporter en XML";
            this.btnExporterXml.UseVisualStyleBackColor = true;
            // 
            // btnImporterXml
            // 
            this.btnImporterXml.Location = new System.Drawing.Point(310, 0);
            this.btnImporterXml.Name = "btnImporterXml";
            this.btnImporterXml.Size = new System.Drawing.Size(80, 23);
            this.btnImporterXml.TabIndex = 7;
            this.btnImporterXml.Text = "Importer XML";
            this.btnImporterXml.UseVisualStyleBackColor = true;
            // 
            // btnExporterXmlShort
            // 
            this.btnExporterXmlShort.Location = new System.Drawing.Point(396, 1);
            this.btnExporterXmlShort.Name = "btnExporterXmlShort";
            this.btnExporterXmlShort.Size = new System.Drawing.Size(140, 23);
            this.btnExporterXmlShort.TabIndex = 8;
            this.btnExporterXmlShort.Text = "Exporter par date en XML";
            this.btnExporterXmlShort.UseVisualStyleBackColor = true;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 483);
            this.Controls.Add(this.btnExporterXmlShort);
            this.Controls.Add(this.btnImporterXml);
            this.Controls.Add(this.btnExporterXml);
            this.Controls.Add(this.btnFiltrerIDClient);
            this.Controls.Add(this.tbIDClient);
            this.Controls.Add(this.lblLigneCommande);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dgvSelectionCommande);
            this.Controls.Add(this.dgvListCommandesClient);
            this.Name = "FormCommandes";
            this.Text = "Commandes par client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandesClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectionCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCommandesClient;
        private System.Windows.Forms.DataGridView dgvSelectionCommande;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblLigneCommande;
        private System.Windows.Forms.TextBox tbIDClient;
        private System.Windows.Forms.Button btnFiltrerIDClient;
        private System.Windows.Forms.Button btnExporterXml;
        private System.Windows.Forms.Button btnImporterXml;
        private System.Windows.Forms.Button btnExporterXmlShort;
    }
}