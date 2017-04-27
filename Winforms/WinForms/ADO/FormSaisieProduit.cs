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
        public FormSaisieProduit()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (DialogResult.Equals(DialogResult.OK))
            {
                ProduitSaisi = new Produit();
                int categorie, fournisseur;
                short uniteEnStock;
                decimal prixUnitaire;
                // Pour le Nom
                ProduitSaisi.Nom = tbNom.Text;
                // Pour la catégorie
                int.TryParse(mtbCategorie.Text, out categorie);
                ProduitSaisi.Catégorie = categorie;
                // Pour la quantité unitaire
                ProduitSaisi.QteUnitaire = tbQteUnitaire.Text;
                // Pour le prix unitaire
                decimal.TryParse(mtbPrixUnitaire.Text, out prixUnitaire);
                ProduitSaisi.PrixUnitaire = prixUnitaire;
                // Pour les unité en stock
                short.TryParse(mtbUniteEnStock.Text, out uniteEnStock);
                ProduitSaisi.UniteEnStock = uniteEnStock;
                // Pour le fournisseur
                int.TryParse(mtbFournisseur.Text, out fournisseur);
                ProduitSaisi.Fournisseur = fournisseur;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            
            base.OnClosing(e);
        }
    }
}
