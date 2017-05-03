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
    public partial class FormSaisieProduit : Form
    {
        public Produit ProduitSaisi { get; set; }
        private List<Categorie> _listeCatégorie;
        private List<Fournisseur> _listeFournisseur;
        public FormSaisieProduit()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult.Equals(DialogResult.OK))
            {
                ProduitSaisi = new Produit();
                short uniteEnStock;
                decimal prixUnitaire;
                // Pour le Nom
                ProduitSaisi.Nom = tbNom.Text;
                // Pour la catégorie
                ProduitSaisi.Catégorie = (int)cbCategorie.SelectedValue;
                // Pour la quantité unitaire
                ProduitSaisi.QteUnitaire = tbQteUnitaire.Text;
                // Pour le prix unitaire
                decimal.TryParse(mtbPrixUnitaire.Text, out prixUnitaire);
                ProduitSaisi.PrixUnitaire = prixUnitaire;
                // Pour les unité en stock
                short.TryParse(mtbUniteEnStock.Text, out uniteEnStock);
                ProduitSaisi.UniteEnStock = uniteEnStock;
                // Pour le fournisseur
                ProduitSaisi.Fournisseur = (int)cbFournisseur.SelectedValue;
            }
            base.OnClosing(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            _listeCatégorie = DAL.GetListeCatégorie();
            cbCategorie.DataSource = _listeCatégorie;
            cbCategorie.DisplayMember = "Nom";
            cbCategorie.ValueMember = "IDCatégorie";
            _listeFournisseur = DAL.GetListFournisseurs();
            cbFournisseur.DataSource = _listeFournisseur;
            cbFournisseur.DisplayMember = "NomEntreprise";
            cbFournisseur.ValueMember = "FournisseurID";
            base.OnLoad(e);
        }
    }
}
