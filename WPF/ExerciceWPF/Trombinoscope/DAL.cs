using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        static public List<Personne> GetPeople()
        {
            List<Personne> listPersonne = new List<Personne>();

            var connectString = Properties.Settings.Default.ConnectionStringNW;
            string sqlQuery = @"SELECT e.EmployeeID, e.FirstName, e.LastName, e.Photo, t.TerritoryDescription,
                                e.ReportsTo, em.FirstName AS MFirstName, em.LastName AS MLastName
                                FROM Territories t
                                INNER JOIN EmployeeTerritories et ON t.TerritoryID = et.TerritoryID
                                RIGHT OUTER JOIN Employees e ON e.EmployeeID = et.EmployeeID
                                LEFT OUTER JOIN Employees em on em.EmployeeID = e.ReportsTo";
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
        private static void GetPeopleFromReader(List<Personne> listPersonne, SqlDataReader reader)
        {
            while (reader.Read())
            {
                int employeeID = (int)reader["EmployeeID"];
                if (listPersonne.Count() == 0 || listPersonne.Last().EmployeeID != employeeID)
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
                    if (reader["ReportsTo"] != DBNull.Value)
                    {
                        personne.ManagerID = (int)reader["ReportsTo"];
                    }
                    if (reader["MFirstName"] != DBNull.Value)
                    {
                        personne.ManagerFirstName = (string)reader["MFirstName"];
                    }
                    if (reader["MLastName"] != DBNull.Value)
                    {
                        personne.ManagerLastName = (string)reader["MLastName"];
                    }
                    listPersonne.Add(personne);
                }
                else if (reader["TerritoryDescription"] != DBNull.Value)
                    listPersonne.Last().ListTerritory.Add((string)reader["TerritoryDescription"]);
            }
        }
        static public void RemoveEmployee(Personne personne)
        {
            var connectString = Properties.Settings.Default.ConnectionStringNW;

            string sqlQuery = @"DELETE Employees
                                FROM Employees
                                WHERE EmployeeID = @EmployeeID";

            var param = new SqlParameter("@EmployeeID", DbType.Int32);
            param.Value = personne.EmployeeID;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                //on initialise la transaction
                SqlTransaction tran = connect.BeginTransaction();

                try
                {
                    var command = new SqlCommand(sqlQuery, connect, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();
                    // si tout se passe bien on commit la transaction
                    tran.Commit();
                }
                catch (Exception)
                {
                    // si un problème survient, on rollback
                    tran.Rollback();
                    throw;
                }
            }
        }
        static public void AddEmployee(Personne personne)
        {
            var connectString = Properties.Settings.Default.ConnectionStringNW;
            string sqlQuery = @"INSERT Employees (FirstName, LastName)
                                VALUES (@FirstName, @LastName)";

            var param = new SqlParameter("@FirstName", DbType.String);
            param.Value = personne.FirstName;
            var param2 = new SqlParameter("@LastName", DbType.String);
            param2.Value = personne.LastName;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                //on initialise la transaction
                SqlTransaction tran = connect.BeginTransaction();

                try
                {
                    var command = new SqlCommand(sqlQuery, connect, tran);
                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);
                    command.ExecuteNonQuery();
                    // si tout se passe bien on commit la transaction
                    tran.Commit();
                }
                catch (Exception)
                {
                    // si un problème survient, on rollback
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
