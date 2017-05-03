using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Produit
    {
        public int IDProduit { get; set; }
        public string Nom { get; set; }
        public int? Catégorie { get; set; }
        public string QteUnitaire { get; set; }
        public decimal? PrixUnitaire { get; set; }
        public int? UniteEnStock { get; set; }
        public int? Fournisseur { get; set; }
    }
}
