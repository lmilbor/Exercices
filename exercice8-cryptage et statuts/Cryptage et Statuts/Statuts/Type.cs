using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statuts
{
    [Flags]
    public enum  Statuts
    {
        Aucun = 0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT = 8,
        SYND = 16
    }
}
