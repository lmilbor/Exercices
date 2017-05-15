using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
            _dataMétéo = new DALMeteo();
            tbDirectory.Text = AppDomain.CurrentDomain.BaseDirectory;
            btnDirectory.Click += BtnDirectory_Click;
            cbVues.SelectionChanged += CbVues_SelectionChanged;
        }
        private void CbVues_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVues.SelectedItem == cbiVignette)
            {
                lbDonnéesMétéo.ItemTemplate = (DataTemplate)Resources["dtVignette"];
                DataContext = _dataMétéo.Stats;
            }
            else if (cbVues.SelectedItem == cbiGroupAnnée)
            {
                lbDonnéesMétéo.ItemTemplate = (DataTemplate)Resources["dtGroupAnnée"];
                DataContext = _dataMétéo.Data;
            }
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
