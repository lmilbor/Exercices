using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SaisieTaches
{
    public class Contexte
    {
        public List<Tache> Taches { get; private set; }
        public Contexte()
        {
            Taches = AccesDonnees.ChargerTaches();
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

        private void EnregistrerTache(object obj)
        {
            throw new NotImplementedException();
        }

        private void SupprimerTache(object obj)
        {
            throw new NotImplementedException();
        }

        private void AjouterTache(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
