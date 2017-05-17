using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Trombinoscope
{
    public class VMMain : ViewModelBase
    {
        // Vue-modèle courante, à laquelle est liée le ContentControl de la zone principale
        private ViewModelBase _VMCourante;
        public ViewModelBase VMCourante
        {
            get { return _VMCourante; }
            private set
            {
                SetProperty(ref _VMCourante, value);
            }
        }

        #region Commandes associées aux menus
        private ICommand _cmdTrombi;
        public ICommand CmdTrombi
        {
            get
            {
                // On définit une instance de VMPersonnes comme vue-modèle courante
                if (_cmdTrombi == null)
                    _cmdTrombi = new RelayCommand((object o) => VMCourante = new ContexteTrombinoscope());
                return _cmdTrombi;
            }
        }

        private ICommand _cmdEmployees;
        public ICommand CmdEmployees
        {
            get
            {
                // On définit une instance de VMPersonnes comme vue-modèle courante
                if (_cmdEmployees == null)
                    _cmdEmployees = new RelayCommand((object o) => { VMCourante = new ContexteEmploye(); });
                return _cmdEmployees;
            }
        }

        #endregion
    }
}
