namespace ADO
{
	partial class MDIForm
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.MenuFournisseurs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaitreDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduits = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFournisseurs,
            this.menuCommandes,
            this.menuProduits,
            this.menuWindows});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(787, 24);
            this.menuGeneral.TabIndex = 0;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // MenuFournisseurs
            // 
            this.MenuFournisseurs.Name = "MenuFournisseurs";
            this.MenuFournisseurs.Size = new System.Drawing.Size(85, 20);
            this.MenuFournisseurs.Text = "Fournisseurs";
            // 
            // menuCommandes
            // 
            this.menuCommandes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandeToolStripMenuItem});
            this.menuCommandes.Name = "menuCommandes";
            this.menuCommandes.Size = new System.Drawing.Size(87, 20);
            this.menuCommandes.Text = "Commandes";
            // 
            // listeCommandeToolStripMenuItem
            // 
            this.listeCommandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaitreDetails});
            this.listeCommandeToolStripMenuItem.Name = "listeCommandeToolStripMenuItem";
            this.listeCommandeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeCommandeToolStripMenuItem.Text = "Liste commande";
            // 
            // menuMaitreDetails
            // 
            this.menuMaitreDetails.Name = "menuMaitreDetails";
            this.menuMaitreDetails.Size = new System.Drawing.Size(152, 22);
            this.menuMaitreDetails.Text = "Maitre details";
            // 
            // menuProduits
            // 
            this.menuProduits.Name = "menuProduits";
            this.menuProduits.Size = new System.Drawing.Size(63, 20);
            this.menuProduits.Text = "Produits";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(63, 20);
            this.menuWindows.Text = "Fenêtres";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 514);
            this.Controls.Add(this.menuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "MDIForm";
            this.Text = "ADO";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuGeneral;
		private System.Windows.Forms.ToolStripMenuItem MenuFournisseurs;
		private System.Windows.Forms.ToolStripMenuItem menuWindows;
		private System.Windows.Forms.ToolStripMenuItem menuCommandes;
        private System.Windows.Forms.ToolStripMenuItem menuProduits;
        private System.Windows.Forms.ToolStripMenuItem listeCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMaitreDetails;
    }
}

