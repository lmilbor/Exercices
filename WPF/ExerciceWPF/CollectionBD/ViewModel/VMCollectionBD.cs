using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Collection_BD
{
    public class VMCollectionBD : ViewModelBase
    {
        public ObservableCollection<CollectionBD> ListCollectionBD { get; }

        public VMCollectionBD()
        {
            ListCollectionBD = new ObservableCollection<CollectionBD>(BD_DAL.ChargerCollectionsBD());
        }

        private ICommand _cmdNavigation;
        public ICommand CmdNavigation
        {
            get
            {
                if (_cmdNavigation == null)
                    _cmdNavigation = new RelayCommand(Naviguer);

                return _cmdNavigation;
            }
        }

        private void Naviguer(object obj)
        {
            // Récupère la vue associée à la collection des achats
            ICollectionView view = CollectionViewSource.GetDefaultView(ListCollectionBD);

            // Navigue dans la collection selon la direction souhaitée
            int lastIndex = GetLastIndex(view);
            switch (obj.ToString())
            {
                case "F":
                    view.MoveCurrentToFirst(); // premier élément
                    break;
                case "P":
                    if (view.CurrentPosition != 0)
                        view.MoveCurrentToPrevious(); // élément précédent
                    break;
                case "N":
                    if (view.CurrentPosition != lastIndex) 
                        view.MoveCurrentToNext();
                    break;
                case "L":
                    view.MoveCurrentToLast(); // dernier élément
                    break;
            }
        }
        private int GetLastIndex(ICollectionView view)
        {
            int currentIndex = view.CurrentPosition;
            view.MoveCurrentToLast();
            int lastIndex = view.CurrentPosition;
            view.MoveCurrentToPosition(currentIndex);
            return lastIndex;
        }
    }
}
