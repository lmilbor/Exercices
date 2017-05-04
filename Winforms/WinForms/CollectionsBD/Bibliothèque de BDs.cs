using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsBD
{
    public partial class FormBibliothèqueDeBDs : Form
    {
        private List<string> _listeTitre;
        public FormBibliothèqueDeBDs()
        {
            InitializeComponent();
            btnFiltreAnnée.Click += BtnFiltreAnnée_Click;
            btnAddAlbum.Click += BtnAddAlbum_Click;
            btnAddAuteur.Click += BtnAddAuteur_Click;
            btnToUpper.Click += BtnToUpper_Click;
        }

        private void BtnToUpper_Click(object sender, EventArgs e)
        {
            //DAL.SetToUpper();
            DAL.SetToUpperAsterix();
        }

        private void BtnAddAuteur_Click(object sender, EventArgs e)
        {
            DAL.AjoutPascalLuckyLuke();
            //DAL.AjoutAuteur(tbAuteur.Text, nananère);
        }

        private void BtnAddAlbum_Click(object sender, EventArgs e)
        {
            //using (var form = new FormSaisieAlbum())
            //{
            //    form.ShowDialog();
            //    if (form.DialogResult.Equals(DialogResult.OK))
            //    {
            //        //TODO
            //    }
            //}
            DAL.AjoutAlbumLuckyLuke();
        }

        private void BtnFiltreAnnée_Click(object sender, EventArgs e)
        {
            _listeTitre = DAL.ListeTitreAlbum(int.Parse(mtbAnnéeDébut.Text), int.Parse(mtbAnnéeFin.Text));
            dgvAlbums.DataSource = _listeTitre;
            lbAlbum.DataSource = _listeTitre;
        }
    }
}
