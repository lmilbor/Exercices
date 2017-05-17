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
        private Personne _newEmployee;
        public ObservableCollection<Personne> Employees { get; }
        public Personne NewEmployee
        {
            get { return _newEmployee; }
            private set
            {
                SetProperty<Personne>(ref _newEmployee, value);
            }
        }
        public ContexteTrombinoscope()
        {
            Employees = new ObservableCollection<Personne>(DAL.GetPeople());
            NewEmployee = new Personne();
        }
    }
}
