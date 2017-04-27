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
            this.lbClient = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandesClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCommandesClient
            // 
            this.dgvListCommandesClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCommandesClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCommandesClient.Location = new System.Drawing.Point(167, 0);
            this.dgvListCommandesClient.Name = "dgvListCommandesClient";
            this.dgvListCommandesClient.Size = new System.Drawing.Size(775, 483);
            this.dgvListCommandesClient.TabIndex = 0;
            // 
            // lbClient
            // 
            this.lbClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbClient.FormattingEnabled = true;
            this.lbClient.Location = new System.Drawing.Point(0, 0);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(98, 483);
            this.lbClient.TabIndex = 1;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 483);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.dgvListCommandesClient);
            this.Name = "FormCommandes";
            this.Text = "Commandes par client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandesClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCommandesClient;
        private System.Windows.Forms.ListBox lbClient;
    }
}