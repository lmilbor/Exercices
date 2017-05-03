using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormProduit : Form
    {
        private BindingList<Produit> _listeProduit;
        private List<Produit> _produitsSupprimés;
        private List<Produit> _produitsAjoutés;
        public FormProduit()
        {
            InitializeComponent();

            #region Initialisation des champs privés
            _produitsAjoutés = new List<Produit>();
            _produitsSupprimés = new List<Produit>();
            #endregion

            #region Abonnement au évènements
            btnPlus.Click += BtnPlus_Click;
            btnMoins.Click += BtnMoins_Click;
            btnEnregistrer.Click += BtnEnregistrer_Click;
            #endregion
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            // Ajout des produits
            DAL.AjouterProduits(_produitsAjoutés);
            _produitsAjoutés.Clear();
            // Suppression des produits
            DAL.SupprimerProduits(_produitsSupprimés);
            _produitsSupprimés.Clear();
            // Rechargement de la liste des produits dans l'affichage
            _listeProduit = DAL.GetListProduit();
            dgvProduits.DataSource = _listeProduit;
        }
        private void BtnMoins_Click(object sender, EventArgs e)
        {
            Produit p = (Produit)dgvProduits.CurrentRow.DataBoundItem;
            if (!_produitsAjoutés.Contains(p))
                _produitsSupprimés.Add(p);
            else
                _produitsAjoutés.Remove(p);
            _listeProduit.Remove(p);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            using (var form = new FormSaisieProduit())
            {
                form.ShowDialog();
                if (form.DialogResult.Equals(DialogResult.OK))
                {
                    _produitsAjoutés.Add(form.ProduitSaisi);
                    _listeProduit.Add(form.ProduitSaisi);

                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            _listeProduit = DAL.GetListProduit();
            dgvProduits.DataSource = _listeProduit;
            base.OnLoad(e);
        }
    }
}
