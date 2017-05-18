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

namespace SaisieTaches
{
    public class Contexte : INotifyPropertyChanged
    {
        private Tache _newTache;
        public Tache NewTache { get; set; }
        private ObservableCollection<Tache> _taches;
        public ObservableCollection<Tache> Taches
        {
            get { return _taches; }
            private set
            {
                if (value != _taches)
                {
                    _taches = value;
                    RaisePropertyChanged();
                }
            }
        }

        private bool _modeEdition;
        public bool ModeEdition
        {
            get { return _modeEdition; }
            private set
            {
                if (value != _modeEdition)
                {
                    _modeEdition = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Contexte()
        {
            NewTache = new Tache();
            NewTache.Id = Taches.Select(t => t.Id).Max() + 1;
            NewTache.Creation = DateTime.Today;
            NewTache.Prio = 1;

            ModeEdition = true;
            Taches = new ObservableCollection<Tache>(AccesDonnees.ChargerTaches());
        }

        // Commande d'ajout
        private ICommand _cmdAjouter;
        public ICommand CmdAjouter
        {
            get
            {
                if (_cmdAjouter == null)
                    _cmdAjouter = new RelayCommand(AjouterTache);

                return _cmdAjouter;
            }
        }

        private ICommand _cmdSupprimer;
        public ICommand CmdSupprimer
        {
            get
            {
                if (_cmdSupprimer == null)
                    _cmdSupprimer = new RelayCommand(SupprimerTache);

                return _cmdSupprimer;
            }
        }

        private ICommand _cmdEnregistrer;
        public ICommand CmdEnregistrer
        {
            get
            {
                if (_cmdEnregistrer == null)
                    _cmdEnregistrer = new RelayCommand(EnregistrerTache);

                return _cmdEnregistrer;
            }
        }

        private ICommand _cmdAnnuler;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CmdAnnuler
        {
            get
            {
                if (_cmdAnnuler == null)
                    _cmdAnnuler = new RelayCommand(Annuler);

                return _cmdAnnuler;
            }
        }

        private void Annuler(object obj)
        {
            ModeEdition = !ModeEdition;
        }

        private void EnregistrerTache(object obj)
        {
            Taches.Add(NewTache);
            ModeEdition = !ModeEdition;
        }

        private void SupprimerTache(object obj)
        {
            var tache = (Tache)CollectionViewSource.GetDefaultView(Taches).CurrentItem;
            Taches.Remove(tache);
        }

        private void AjouterTache(object obj)
        {
            ModeEdition = !ModeEdition;
        }
        private void RaisePropertyChanged([CallerMemberName] string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
