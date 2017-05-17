using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Trombinoscope
{
    public class Personne : INotifyPropertyChanged
    {
        public int EmployeeID { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public ImageSource Picture { get; set; }
        public List<string> ListTerritory { get; set; }
        public int ManagerID { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerFirstName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
