namespace Exercice1
{
    partial class winAnalyseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winAnalyseur));
            this.lblDossierAnalyser = new System.Windows.Forms.Label();
            this.btnAnalyser = new System.Windows.Forms.Button();
            this.Afficher = new System.Windows.Forms.GroupBox();
            this.checkFichiersProjets = new System.Windows.Forms.CheckBox();
            this.checkNomLong = new System.Windows.Forms.CheckBox();
            this.checkNbFichierCs = new System.Windows.Forms.CheckBox();
            this.checkNbFichiers = new System.Windows.Forms.CheckBox();
            this.panelFichiersProjet = new System.Windows.Forms.Panel();
            this.ResultatsFichiersProjet = new System.Windows.Forms.Label();
            this.btnRepertoire = new System.Windows.Forms.Button();
            this.lblNbFichiers = new System.Windows.Forms.Label();
            this.lblresNbFichiersCs = new System.Windows.Forms.Label();
            this.lblNomLong = new System.Windows.Forms.Label();
            this.lblresNomLong = new System.Windows.Forms.Label();
            this.lblresNbFichiers = new System.Windows.Forms.Label();
            this.lblNbFichiersCs = new System.Windows.Forms.Label();
            this.listBoxFichiersProjet = new System.Windows.Forms.ListBox();
            this.textDossier = new System.Windows.Forms.TextBox();
            this.Afficher.SuspendLayout();
            this.panelFichiersProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDossierAnalyser
            // 
            resources.ApplyResources(this.lblDossierAnalyser, "lblDossierAnalyser");
            this.lblDossierAnalyser.Name = "lblDossierAnalyser";
            // 
            // btnAnalyser
            // 
            resources.ApplyResources(this.btnAnalyser, "btnAnalyser");
            this.btnAnalyser.Name = "btnAnalyser";
            this.btnAnalyser.UseVisualStyleBackColor = true;
            // 
            // Afficher
            // 
            resources.ApplyResources(this.Afficher, "Afficher");
            this.Afficher.Controls.Add(this.checkFichiersProjets);
            this.Afficher.Controls.Add(this.checkNomLong);
            this.Afficher.Controls.Add(this.checkNbFichierCs);
            this.Afficher.Controls.Add(this.checkNbFichiers);
            this.Afficher.Name = "Afficher";
            this.Afficher.TabStop = false;
            // 
            // checkFichiersProjets
            // 
            resources.ApplyResources(this.checkFichiersProjets, "checkFichiersProjets");
            this.checkFichiersProjets.Checked = global::Exercice1.Properties.Settings.Default.CheckListFichiers;
            this.checkFichiersProjets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFichiersProjets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Exercice1.Properties.Settings.Default, "CheckListFichiers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkFichiersProjets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkFichiersProjets.Name = "checkFichiersProjets";
            this.checkFichiersProjets.UseVisualStyleBackColor = true;
            // 
            // checkNomLong
            // 
            resources.ApplyResources(this.checkNomLong, "checkNomLong");
            this.checkNomLong.Checked = global::Exercice1.Properties.Settings.Default.CheckFichierLong;
            this.checkNomLong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNomLong.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Exercice1.Properties.Settings.Default, "CheckFichierLong", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkNomLong.Name = "checkNomLong";
            this.checkNomLong.UseVisualStyleBackColor = true;
            // 
            // checkNbFichierCs
            // 
            resources.ApplyResources(this.checkNbFichierCs, "checkNbFichierCs");
            this.checkNbFichierCs.Checked = global::Exercice1.Properties.Settings.Default.CheckNbFichiersCs;
            this.checkNbFichierCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNbFichierCs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Exercice1.Properties.Settings.Default, "CheckNbFichiersCs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkNbFichierCs.Name = "checkNbFichierCs";
            this.checkNbFichierCs.UseVisualStyleBackColor = true;
            // 
            // checkNbFichiers
            // 
            resources.ApplyResources(this.checkNbFichiers, "checkNbFichiers");
            this.checkNbFichiers.Checked = global::Exercice1.Properties.Settings.Default.CheckNbFichiers;
            this.checkNbFichiers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNbFichiers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Exercice1.Properties.Settings.Default, "CheckNbFichiers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkNbFichiers.Name = "checkNbFichiers";
            this.checkNbFichiers.UseVisualStyleBackColor = true;
            // 
            // panelFichiersProjet
            // 
            resources.ApplyResources(this.panelFichiersProjet, "panelFichiersProjet");
            this.panelFichiersProjet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFichiersProjet.Controls.Add(this.ResultatsFichiersProjet);
            this.panelFichiersProjet.Name = "panelFichiersProjet";
            // 
            // ResultatsFichiersProjet
            // 
            resources.ApplyResources(this.ResultatsFichiersProjet, "ResultatsFichiersProjet");
            this.ResultatsFichiersProjet.Name = "ResultatsFichiersProjet";
            // 
            // btnRepertoire
            // 
            resources.ApplyResources(this.btnRepertoire, "btnRepertoire");
            this.btnRepertoire.Name = "btnRepertoire";
            this.btnRepertoire.UseVisualStyleBackColor = true;
            // 
            // lblNbFichiers
            // 
            resources.ApplyResources(this.lblNbFichiers, "lblNbFichiers");
            this.lblNbFichiers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNbFichiers.Name = "lblNbFichiers";
            // 
            // lblresNbFichiersCs
            // 
            resources.ApplyResources(this.lblresNbFichiersCs, "lblresNbFichiersCs");
            this.lblresNbFichiersCs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblresNbFichiersCs.Name = "lblresNbFichiersCs";
            // 
            // lblNomLong
            // 
            resources.ApplyResources(this.lblNomLong, "lblNomLong");
            this.lblNomLong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomLong.Name = "lblNomLong";
            // 
            // lblresNomLong
            // 
            resources.ApplyResources(this.lblresNomLong, "lblresNomLong");
            this.lblresNomLong.Name = "lblresNomLong";
            // 
            // lblresNbFichiers
            // 
            resources.ApplyResources(this.lblresNbFichiers, "lblresNbFichiers");
            this.lblresNbFichiers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblresNbFichiers.Name = "lblresNbFichiers";
            // 
            // lblNbFichiersCs
            // 
            resources.ApplyResources(this.lblNbFichiersCs, "lblNbFichiersCs");
            this.lblNbFichiersCs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNbFichiersCs.Name = "lblNbFichiersCs";
            // 
            // listBoxFichiersProjet
            // 
            resources.ApplyResources(this.listBoxFichiersProjet, "listBoxFichiersProjet");
            this.listBoxFichiersProjet.FormattingEnabled = true;
            this.listBoxFichiersProjet.Name = "listBoxFichiersProjet";
            // 
            // textDossier
            // 
            resources.ApplyResources(this.textDossier, "textDossier");
            this.textDossier.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Exercice1.Properties.Settings.Default, "Repertoire", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textDossier.Name = "textDossier";
            this.textDossier.Text = global::Exercice1.Properties.Settings.Default.Repertoire;
            // 
            // winAnalyseur
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxFichiersProjet);
            this.Controls.Add(this.lblNbFichiersCs);
            this.Controls.Add(this.lblresNbFichiers);
            this.Controls.Add(this.lblresNomLong);
            this.Controls.Add(this.lblNomLong);
            this.Controls.Add(this.lblresNbFichiersCs);
            this.Controls.Add(this.lblNbFichiers);
            this.Controls.Add(this.btnRepertoire);
            this.Controls.Add(this.panelFichiersProjet);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.btnAnalyser);
            this.Controls.Add(this.textDossier);
            this.Controls.Add(this.lblDossierAnalyser);
            this.Name = "winAnalyseur";
            this.Afficher.ResumeLayout(false);
            this.Afficher.PerformLayout();
            this.panelFichiersProjet.ResumeLayout(false);
            this.panelFichiersProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDossierAnalyser;
        private System.Windows.Forms.TextBox textDossier;
        private System.Windows.Forms.Button btnAnalyser;
        private System.Windows.Forms.GroupBox Afficher;
        private System.Windows.Forms.CheckBox checkFichiersProjets;
        private System.Windows.Forms.CheckBox checkNomLong;
        private System.Windows.Forms.CheckBox checkNbFichierCs;
        private System.Windows.Forms.CheckBox checkNbFichiers;
        private System.Windows.Forms.Panel panelFichiersProjet;
        private System.Windows.Forms.Label ResultatsFichiersProjet;
        private System.Windows.Forms.Button btnRepertoire;
        private System.Windows.Forms.Label lblNbFichiers;
        private System.Windows.Forms.Label lblresNbFichiersCs;
        private System.Windows.Forms.Label lblNomLong;
        private System.Windows.Forms.Label lblresNomLong;
        private System.Windows.Forms.Label lblresNbFichiers;
        private System.Windows.Forms.Label lblNbFichiersCs;
        private System.Windows.Forms.ListBox listBoxFichiersProjet;
    }
}

