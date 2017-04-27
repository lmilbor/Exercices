using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class CommandesClient
    {
        public int IDcommande { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime DateEnvoi { get; set; }
        public int NbProduits { get; set; }
        public decimal MontantTotal { get; set; }
        public decimal FraisEnvoi { get; set; }
    }
}
