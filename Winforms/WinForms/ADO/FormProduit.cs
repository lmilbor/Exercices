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
    public partial class FormProduit : Form
    {
        public BindingList<Produit> ListeProduit { get; set; }
        public Produit SuppressionProduit { get; set; }
        public Produit AjoutProduit { get; set; }
        public FormProduit()
        {
            InitializeComponent();
            btnPlus.Click += BtnPlus_Click;
            btnMoins.Click += BtnMoins_Click;
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            DAL.RemoveProduit((Produit)dgvProduits.CurrentRow.DataBoundItem);
            ListeProduit.Remove((Produit)dgvProduits.CurrentRow.DataBoundItem);

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            using (var form = new FormSaisieProduit())
            {
                form.ShowDialog();
                if (form.DialogResult.Equals(DialogResult.OK))
                {
                    DAL.InsertProduit(form.ProduitSaisi);
                    ListeProduit = DAL.GetListProduit(); // On recharge tout le tableau pour avoir le ProductID qui va bien
                    dgvProduits.DataSource = ListeProduit; // Comme on a fait un "ListeProduit = qqc" on a changé de pointeur, il faut donc l'indiquer à DataGridView
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            ListeProduit = DAL.GetListProduit();
            dgvProduits.DataSource = ListeProduit;
            base.OnLoad(e);
        }
    }
}
