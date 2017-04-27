using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExplorateurFichiers;

namespace Exercice1
{
    public partial class winAnalyseur : Form
    {
        public winAnalyseur()
        {
            //Data Source=LMILBOR17-DE\IP08R2;Initial Catalog=Northwind;Integrated Security=True
            InitializeComponent();
            // Gestion des boutons.
            btnRepertoire.Click += BtnRepertoire_Click;
            btnAnalyser.Click += BtnAnalyser_Click;
            checkNbFichiers.CheckStateChanged += CheckNbFichiers_CheckStateChanged;
            checkNbFichierCs.CheckStateChanged += CheckNbFichierCs_CheckStateChanged;
            checkNomLong.CheckStateChanged += CheckNomLong_CheckStateChanged;
            //checkFichiersProjets.CheckStateChanged += CheckFichiersProjets_CheckStateChanged;
            //On utilise un lambda expression à la place de la synthaxe classique.
            checkFichiersProjets.CheckStateChanged += (object sender, EventArgs e) => {
                listBoxFichiersProjet.Visible = checkFichiersProjets.Checked;
                panelFichiersProjet.Visible = checkFichiersProjets.Checked;
            };
            // A la fermeture.
            this.FormClosing += WinAnalyseur_FormClosing;
        }

        private void WinAnalyseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Voulez-vous asuvegarder vos préférences avant de quitter ?",
                "Sortie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Properties.Settings.Default.CheckListFichiers = checkFichiersProjets.Checked;
                    Properties.Settings.Default.CheckFichierLong = checkNomLong.Checked;
                    Properties.Settings.Default.CheckNbFichiersCs = checkNbFichierCs.Checked;
                    Properties.Settings.Default.CheckNbFichiers = checkNbFichiers.Checked;
                    Properties.Settings.Default.Repertoire = textDossier.Text;
                    Properties.Settings.Default.Save();
                    break;
                case DialogResult.No:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        //private void CheckFichiersProjets_CheckStateChanged(object sender, EventArgs e)
        //{
        //    listBoxFichiersProjet.Visible = checkFichiersProjets.Checked;
        //    panelFichiersProjet.Visible = checkFichiersProjets.Checked;
        //}

        private void CheckNomLong_CheckStateChanged(object sender, EventArgs e)
        {
            lblNomLong.Visible = checkNomLong.Checked;
            lblresNomLong.Visible = checkNomLong.Checked;
        }

        private void CheckNbFichierCs_CheckStateChanged(object sender, EventArgs e)
        {
            lblNbFichiersCs.Visible = checkNbFichierCs.Checked;
            lblresNbFichiersCs.Visible = checkNbFichierCs.Checked;
        }

        private void CheckNbFichiers_CheckStateChanged(object sender, EventArgs e)
        {
            lblresNbFichiers.Visible = checkNbFichiers.Checked;
            lblNbFichiers.Visible = checkNbFichiers.Checked;
        }

        private void BtnAnalyser_Click(object sender, EventArgs e)
        {
            Analyseur.AnalyserDossier(textDossier.Text);
            lblresNbFichiers.Text = Analyseur.NombreFichiers.ToString();
            lblresNbFichiersCs.Text = Analyseur.NombreFichiersCs.ToString();
            lblresNomLong.Text = Analyseur.NomFichierPlusGrand;
            foreach (var item in Analyseur.NomFichiers)
            {
                listBoxFichiersProjet.Items.Add(item);
            }
        }

        private void BtnRepertoire_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog slctDossier = new FolderBrowserDialog();
            if (slctDossier.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(slctDossier.SelectedPath))
                textDossier.Text = slctDossier.SelectedPath;
        }
    }
}
