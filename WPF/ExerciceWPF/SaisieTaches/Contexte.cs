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
        #region Champs privés et Propriétées
        private Tache _tacheCourante;
        public Tache TacheCourante
        {
            get { return _tacheCourante; }
            set
            {
                if (value != _tacheCourante)
                {
                    _tacheCourante = value;
                    RaisePropertyChanged();
                }
            }
        }
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
        #endregion
        
        #region Champs privés et propriétées des commandes
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
        public ICommand CmdAnnuler
        {
            get
            {
                if (_cmdAnnuler == null)
                    _cmdAnnuler = new RelayCommand(Annuler);

                return _cmdAnnuler;
            }
        } 
        #endregion
        
        /// <summary>
        /// Constructeur qui initialise Taches et ModeEdition
        /// </summary>
        public Contexte()
        {
            ModeEdition = true;
            Taches = new ObservableCollection<Tache>(AccesDonnees.ChargerTaches());
        }
        
        #region Méthodes privées liées aux commandes
        private void Annuler(object obj)
        {
            Taches.Remove(TacheCourante);
            ModeEdition = !ModeEdition;
        }

        private void EnregistrerTache(object obj)
        {
            AccesDonnees.EnregistrerTaches(Taches.ToList());
            ModeEdition = !ModeEdition;
        }

        private void SupprimerTache(object obj)
        {
            var tache = (Tache)CollectionViewSource.GetDefaultView(Taches).CurrentItem;
            Taches.Remove(tache);
            AccesDonnees.EnregistrerTaches(Taches.ToList());
        }

        private void AjouterTache(object obj)
        {
            TacheCourante = new Tache();
            TacheCourante.Id = Taches.Any() ? Taches.Max(t => t.Id) + 1 : 1;
            TacheCourante.Creation = DateTime.Today;
            TacheCourante.Term = DateTime.Today;
            TacheCourante.Prio = 1;
            Taches.Add(TacheCourante);
            ModeEdition = !ModeEdition;
        }
        #endregion

        #region Gestion de MAJ de l'affichage après MAJ des données
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        } 
        #endregion

    }
}
