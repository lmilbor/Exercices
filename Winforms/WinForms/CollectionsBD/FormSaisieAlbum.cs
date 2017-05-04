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
    public partial class FormSaisieAlbum : Form
    {
        public Album NewAlbum { get; set; }
        public string Auteur { get; set; }
        public FormSaisieAlbum()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult.Equals(DialogResult.OK))
            {
                NewAlbum = new Album();
                Auteur = tbAuteur.Text;
                NewAlbum.Titre = tbTitre.Text;
                NewAlbum.Année = int.Parse(mtbAnnée.Text);;
            }
            base.OnClosing(e);
        }
    }
}
