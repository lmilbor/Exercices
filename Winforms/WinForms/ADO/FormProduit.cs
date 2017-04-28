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
        private bool _autreCategorieCree;
        private List<Categorie> _listeCatégorie;
        private Produit _suppressionProduit;
        private Produit _ajoutProduit;
        public FormProduit()
        {
            InitializeComponent();
            btnPlus.Click += BtnPlus_Click;
            btnMoins.Click += BtnMoins_Click;
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.RemoveProduit((Produit)dgvProduits.CurrentRow.DataBoundItem);
                _listeProduit.Remove((Produit)dgvProduits.CurrentRow.DataBoundItem);
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 547)
                {
                    var res = MessageBox.Show("Impossible de supprimer ce produit. (Des commandes sont peut-être encore en cours)",
                                                                              "Suppression impossible", MessageBoxButtons.OK);
                }
                else
                    throw;
            }

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            using (var form = new FormSaisieProduit())
            {
                form.ShowDialog();
                if (form.DialogResult.Equals(DialogResult.OK))
                {
                    try
                    {
                            if (_listeCatégorie.Exists(c => c.IDCatégorie == form.ProduitSaisi.Catégorie))
                            {
                                {
                                    DAL.InsertProduit(form.ProduitSaisi);
                                    _listeProduit = DAL.GetListProduit(); // On recharge tout le tableau pour avoir le ProductID qui va bien
                                    dgvProduits.DataSource = _listeProduit; // Comme on a fait un "ListeProduit = qqc" on a changé de pointeur, il faut donc l'indiquer à DataGridView
                                }
                            }
                            else if (_autreCategorieCree)
                            {
                                DAL.InsertProduit(form.ProduitSaisi, _listeCatégorie.Where(c => c.Nom == "Autres produits").First());
                                _listeProduit = DAL.GetListProduit();
                                dgvProduits.DataSource = _listeProduit;
                            }
                            else
                        {
                            DAL.AddCategorie();
                            DAL.GetListeCatégorie();
                            DAL.InsertProduit(form.ProduitSaisi, _listeCatégorie.Where(c => c.Nom == "Autres produits").First());
                            _listeProduit = DAL.GetListProduit();
                            dgvProduits.DataSource = _listeProduit;
                            _autreCategorieCree = true;
                        }
                    }
                    catch (SqlException sqle)
                    {
                        if (sqle.Number == 547)
                        {
                            var res = MessageBox.Show("Impossible d'ajouter ce produit. (Vérifiez les identifants de fournisseur et/ou de catégorie.)",
                                                                                         "Ajout impossible", MessageBoxButtons.OK);
                        }
                        else
                            throw;
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            _listeProduit = DAL.GetListProduit();
            _listeCatégorie = DAL.GetListeCatégorie();
            dgvProduits.DataSource = _listeProduit;
            base.OnLoad(e);
        }
    }
}
