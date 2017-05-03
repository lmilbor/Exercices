using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormCommandes : Form
    {
        private BindingList<Commande> _listeCommande;
        public FormCommandes()
        {
            InitializeComponent();
            dgvSelectionCommande.CellMouseClick += DgvSelectionCommande_CellMouseClick;
            btnFiltrerIDClient.Click += BtnFiltrerIDClient_Click;
            btnExporterXml.Click += BtnExporterXml_Click;
            btnImporterXml.Click += BtnImporterXml_Click;
        }

        private void BtnImporterXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog slctDossier = new OpenFileDialog();
            if (slctDossier.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(slctDossier.FileName))
            {
                _listeCommande = DAL.ImporterXml(slctDossier.FileName);
                dgvSelectionCommande.DataSource = _listeCommande;
            }
        }

        private void BtnExporterXml_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog slctDossier = new FolderBrowserDialog();
            if (slctDossier.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(slctDossier.SelectedPath))
                DAL.ExporterXml(_listeCommande, slctDossier.SelectedPath);
        }

        private void BtnFiltrerIDClient_Click(object sender, EventArgs e)
        {
            List<Commande> lc = _listeCommande.Where(c => c.IDClient == tbIDClient.Text.ToUpper()).ToList();
            if (string.IsNullOrWhiteSpace(tbIDClient.Text))
            {
                dgvSelectionCommande.DataSource = _listeCommande;
                dgvListCommandesClient.DataSource = null;
            }
            else if (lc.Count == 0)
                MessageBox.Show("L'identifiant client entré n'est pas référencé.");
            else
                dgvSelectionCommande.DataSource = lc;

            #region Trie par IDCommande
            //if (!string.IsNullOrWhiteSpace(tbIDClient.Text))
            //{
            //    int id = int.Parse(tbIDClient.Text);
            //    dgvSelectionCommande.DataSource = _listeCommande.Where(c => c.IDCommande == id).ToList();
            //    dgvListCommandesClient.DataSource = _listeCommande.Where(c => c.IDCommande == id).Select(c => c.LigneCommande).FirstOrDefault();
            //} 
            #endregion

        }

        private void DgvSelectionCommande_CellMouseClick(object sender, EventArgs e)
        {
            dgvListCommandesClient.DataSource = ((Commande)dgvSelectionCommande.CurrentRow.DataBoundItem).LigneCommande;
        }

        protected override void OnLoad(EventArgs e)
        {
            //_listeCommande = DAL.GetListCommande();
            //dgvSelectionCommande.DataSource = _listeCommande;
            base.OnLoad(e);
        }
    }
}
