using Microsoft.Win32;
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

namespace RelevésMétéo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DALMeteo _dataMétéo;
        public MainWindow()
        {
            InitializeComponent();
            //Language = System.Windows.Markup.
            _dataMétéo = new DALMeteo();
            tbDirectory.Text = AppDomain.CurrentDomain.BaseDirectory;
            btnDirectory.Click += BtnDirectory_Click;
            cbVues.SelectionChanged += CbVues_SelectionChanged;
            cbTri.SelectionChanged += CbVues_SelectionChanged;
            cbOrdreTri.SelectionChanged += CbVues_SelectionChanged;
        }
        private void CbVues_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(_dataMétéo.Data);
            view.SortDescriptions.Clear();
            view.GroupDescriptions.Clear();

            if (cbVues.SelectedItem == cbiVignette)
            {
                lbDonnéesMétéo.ItemTemplate = (DataTemplate)Resources["dtVignette"];
                DataContext = _dataMétéo.Stats;
            }
            else if (cbVues.SelectedItem == cbiGroupAnnée)
            {

                lbDonnéesMétéo.ItemTemplate = (DataTemplate)Resources["dtGroupAnnée"];
                view.SortDescriptions.Add(new SortDescription("Année", ListSortDirection.Ascending));
                view.GroupDescriptions.Add(new PropertyGroupDescription("Année"));
                DataContext = _dataMétéo.Data;
            }
            var sens = cbOrdreTri.SelectedIndex == 0 ? ListSortDirection.Ascending :
                                                      ListSortDirection.Descending;
            var tri = new SortDescription(cbTri.SelectedValue.ToString(), sens);
            view.SortDescriptions.Add(tri);
        }
        private void BtnDirectory_Click(object sender, RoutedEventArgs e)
        {
            var dial = new OpenFileDialog();
            dial.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dial.Title = "Ouvrir un fichier";
            dial.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dial.FileName) && dial.CheckFileExists)
            {
                tbDirectory.Text = dial.FileName;
                _dataMétéo.ChargerDonnées(dial.FileName);
                DataContext = _dataMétéo.Stats;
                lbDonnéesMétéo.DataContext = _dataMétéo.Data;
            }
        }
    }
}
