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
    public partial class FormFournisseurs : Form
    {
        public FormFournisseurs()
        {
            InitializeComponent();
            cbListPays.SelectedValueChanged += CbListPays_Click;
        }
        private void CbListPays_Click(object sender, EventArgs e)
        {
            dgvListFournisseurs.DataSource = DAL.GetListFournisseurs(cbListPays.SelectedValue.ToString());
            lblresNbProduitsFournisseur.Text = DAL.GetNbProduitsPays(cbListPays.SelectedValue.ToString()).ToString();
        }
        protected override void OnLoad(EventArgs e)
        {
            dgvListFournisseurs.DataSource = DAL.GetListFournisseurs(cbListPays.SelectedText.ToString());
            cbListPays.DataSource = DAL.GetListPays();
            //dgvProduits.DataSource = DAL.GetListProduit(qreg);
            base.OnLoad(e);
        }
    }
}
