using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Trombinoscope
{
    static public class DAL
    {
        private static ImageSource ConvertBytesToImageSource(Byte[] tab)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Les images stockées dans la base Northwind ont un en-tête de 78 octets 
                // qu'il faut enlever pour pouvoir les charger correctement
                ms.Write(tab, 78, tab.Length - 78);
                ImageSource image = BitmapFrame.Create(ms, BitmapCreateOptions.None,
                                      BitmapCacheOption.OnLoad);
                return image;
            }
        }
        static public BindingList<Personne> GetPeople()
        {
            BindingList<Personne> listPersonne = new BindingList<Personne>();

            var connectString = Properties.Settings.Default.ConnectionStringNW;
            string sqlQuery = @"SELECT e.EmployeeID, e.FirstName, e.LastName, e.Photo, t.TerritoryDescription
                                FROM Territories t
                                INNER JOIN EmployeeTerritories et ON t.TerritoryID = et.TerritoryID
                                RIGHT OUTER JOIN Employees e ON e.EmployeeID = et.EmployeeID";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GetPeopleFromReader(listPersonne, reader);
                }
            }
            return listPersonne;
        }

        private static void GetPeopleFromReader(BindingList<Personne> listPersonne, SqlDataReader reader)
        {
            while (reader.Read())
            {
                int employeeID = (int)reader["EmployeeID"];
                if (listPersonne.Count()==0 || listPersonne.Last().EmployeeID != employeeID)
                {
                    Personne personne = new Personne();
                    personne.EmployeeID = employeeID;
                    personne.FirstName = (string)reader["FirstName"];
                    personne.LastName = (string)reader["LastName"];
                    if (reader["Photo"] != DBNull.Value)
                    {
                        personne.Picture = ConvertBytesToImageSource((Byte[])reader["Photo"]);
                    }
                    personne.ListTerritory = new List<string>();
                    listPersonne.Add(personne);
                }
                else if (reader["TerritoryDescription"] != DBNull.Value)
                    listPersonne.Last().ListTerritory.Add((string)reader["TerritoryDescription"]);
            }
        }
    }
}
