using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Trombinoscope
{
    /// <summary>
    /// Interaction logic for UCEmployes.xaml
    /// </summary>
    public partial class UCEmployes : UserControl
    {
        private BindingList<Personne> _listPersonne;
        public UCEmployes()
        {
            InitializeComponent();

            _listPersonne = DAL.GetPeople();
            listEmployes.SelectedValuePath = "personne";
            listEmployes.DisplayMemberPath = "nomComplet";
            listEmployes.ItemsSource = _listPersonne.Select(p =>
                new { personne = p, nomComplet = p.FirstName + " " + p.LastName }).ToList();
            listEmployes.SelectionChanged += ListEmployes_SelectionChanged;
        }

        private void ListEmployes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeInfo.Text = _listPersonne.Where(p => p.EmployeeID == ((Personne)listEmployes.SelectedValue).EmployeeID).
                Select(p => string.Format("Identifiant : {0}\nNom et Prénom : {2} {1}",
                p.EmployeeID, p.FirstName, p.LastName)).FirstOrDefault();
        }
    }
}
