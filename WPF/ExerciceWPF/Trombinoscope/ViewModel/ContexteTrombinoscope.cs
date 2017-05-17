using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trombinoscope
{
    public class ContexteTrombinoscope : VMMain
    {
        public ObservableCollection<Personne> Employees { get; }
        public ContexteTrombinoscope()
        {
            Employees = new ObservableCollection<Personne>(DAL.GetPeople());
        }
    }
}
