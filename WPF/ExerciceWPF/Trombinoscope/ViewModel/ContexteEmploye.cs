using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Trombinoscope
{
    public class ContexteEmploye : VMMain
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
        public ContexteEmploye()
        {
            Employees = new ObservableCollection<Personne>(DAL.GetPeople());
            NewEmployee = new Personne();
        }

        // Commande d'ajout
        private ICommand _cmdAdd;
        public ICommand CmdAdd
        {
            get
            {
                if (_cmdAdd == null)
                    _cmdAdd = new RelayCommand(AddEmployee);

                return _cmdAdd;
            }
        }

        // Commande pour vider les text box
        private ICommand _cmdRemove;
        public ICommand CmdRemove
        {
            get
            {
                if (_cmdRemove == null)
                    _cmdRemove = new RelayCommand(RemoveEmployee);

                return _cmdRemove;
            }
        }
        private void AddEmployee(object obj)
        {
            if (!(string.IsNullOrWhiteSpace(NewEmployee.FirstName) || string.IsNullOrWhiteSpace(NewEmployee.LastName)))
            {
                Employees.Add(NewEmployee);
                DAL.AddEmployee(NewEmployee);
                NewEmployee = new Personne();
            }
        }
        private void RemoveEmployee(object obj)
        {
            var e = (Personne)CollectionViewSource.GetDefaultView(Employees).CurrentItem;
            DAL.RemoveEmployee(e);
            Employees.Remove(e);
        }
    }
}
