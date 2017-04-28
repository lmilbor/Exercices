using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace ADO
{
    static public class DAL
    {
        static public List<Fournisseur> GetListFournisseurs(string pays)
        {
            List<Fournisseur> listFournisseurs = new List<Fournisseur>();
            // On récupère la chaîne de connexion stockée
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            //On prépare notre requête sql
            string sqlQuery = @"SELECT CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country
                                FROM Suppliers WHERE Country = @Pays ORDER BY Country";
            var param = new SqlParameter("@Pays", DbType.String);
            param.Value = pays;
            // On crée une connexion
            using (var connect = new SqlConnection(connectString))
            {
                //on crée la commande relative à la requête
                var command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add(param);
                //on ouvre la connexion
                connect.Open();
                //on exécute la requête
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fournisseur = new Fournisseur();
                        fournisseur.NomEntreprise = (string)reader["CompanyName"];
                        if (reader["ContactName"] != DBNull.Value)
                            fournisseur.NomContact = (string)reader["ContactName"];
                        if (reader["ContactTitle"] != DBNull.Value)
                            fournisseur.TitreContact = (string)reader["ContactTitle"];
                        if (reader["Address"] != DBNull.Value)
                            fournisseur.Adresse = (string)reader["Address"];
                        if (reader["City"] != DBNull.Value)
                            fournisseur.Ville = (string)reader["City"];
                        if (reader["Region"] != DBNull.Value)
                            fournisseur.Région = (string)reader["Region"];
                        if (reader["PostalCode"] != DBNull.Value)
                            fournisseur.CodePostal = (string)reader["PostalCode"];
                        if (reader["Country"] != DBNull.Value)
                            fournisseur.Pays = (string)reader["Country"];
                        listFournisseurs.Add(fournisseur);
                    }
                }
            }
            return listFournisseurs;
        }
        static public List<Région> GetListeRégion()
        {
            List<Région> listRégions = new List<Région>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = "SELECT RegionID, RegionDescription FROM Region";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var région = new Région();
                        région.Id = (int)reader["RegionID"];
                        région.Description = (string)reader["RegionDescription"];
                        listRégions.Add(région);
                    }
                }
            }
            return listRégions;
        }
        static public List<string> GetListPays()
        {
            var listPays = new List<string>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = "SELECT distinct Country FROM Suppliers ORDER BY Country";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listPays.Add(reader.GetString(0));
                    }
                }
            }
            return listPays;
        }
        static public int GetNbProduitsPays(string pays)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"select COUNT(ProductID) from Suppliers s
                                inner join Products p on p.SupplierID = s.SupplierID
                                where Country = @pays";
            var param = new SqlParameter("@Pays", DbType.String);
            param.Value = pays;
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add(param);
                connect.Open();
                return (int)command.ExecuteScalar();
            }
        }
        static public List<CommandesClient> GetCommandesClient(string ClientID)
        {
            var listCommandesClient = new List<CommandesClient>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = "SELECT * FROM ufn_CommandesClient (@ClientID)";
            var param = new SqlParameter("@ClientID", DbType.String);
            param.Value = ClientID;
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add(param);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var commandesClient = new CommandesClient();
                        commandesClient.IDcommande = reader.GetInt32(0);
                        if (!reader.IsDBNull(1))
                            commandesClient.DateCommande = reader.GetDateTime(1);
                        if (!reader.IsDBNull(2))
                            commandesClient.DateEnvoi = reader.GetDateTime(2);
                        if (!reader.IsDBNull(3))
                            commandesClient.NbProduits = reader.GetInt32(3);
                        if (!reader.IsDBNull(4))
                            commandesClient.MontantTotal = reader.GetDecimal(4);
                        if (!reader.IsDBNull(5))
                            commandesClient.FraisEnvoi = reader.GetDecimal(5);
                        listCommandesClient.Add(commandesClient);

                    }
                }
            }
            return listCommandesClient;
        }
        static public List<string[]> GetListClient()
        {
            var listClients = new List<string[]>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"select CustomerID, CompanyName from Customers";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] client = new string[] { reader.GetString(0), reader.GetString(1) };
                        listClients.Add(client);
                    }
                }
            }
            return listClients;
        }
        static public List<string> GetListClientNom()
        {
            List<string> listNomClient = new List<string>();
            foreach (var item in GetListClient())
            {
                listNomClient.Add(item[0]);
            }
            return listNomClient;
        }
        static private void GetListProduitFromReader(BindingList<Produit> listProduit, SqlDataReader reader)
        {
            while (reader.Read())
            {
                var produit = new Produit();
                produit.IDProduit = (int)reader["ProductID"];
                if (reader["ProductName"] != DBNull.Value)
                    produit.Nom = (string)reader["ProductName"];
                if (reader["CategoryID"] != DBNull.Value)
                    produit.Catégorie = (int)reader["CategoryID"];
                if (reader["QuantityPerUnit"] != DBNull.Value)
                    produit.QteUnitaire = (string)reader["QuantityPerUnit"];
                if (reader["UnitPrice"] != DBNull.Value)
                    produit.PrixUnitaire = (decimal)reader["UnitPrice"];
                if (reader["UnitsInStock"] != DBNull.Value)
                    produit.UniteEnStock = (short)reader["UnitsInStock"];
                if (reader["SupplierID"] != DBNull.Value)
                    produit.Fournisseur = (int)reader["SupplierID"];
                listProduit.Add(produit);
            }
        }
        static public BindingList<Produit> GetListProduit()
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"select ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID from Products";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GetListProduitFromReader(listProduit, reader);
                }
            }
            return listProduit;
        }
        static public void InsertProduit(Produit produit)
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"INSERT Products (ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID)
                                VALUES (@ProductName, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @SupplierID)";

            #region Définition des paramètres
            var productName = new SqlParameter("@ProductName", DbType.String);
            var categoryID = new SqlParameter("@CategoryID", DbType.Int32);
            var quantityPerUnit = new SqlParameter("@QuantityPerUnit", DbType.String);
            var unitPrice = new SqlParameter("@UnitPrice", DbType.Decimal);
            var unitsInStock = new SqlParameter("@UnitsInStock", DbType.Int16);
            var supplierID = new SqlParameter("@SupplierID", DbType.Int32);

            productName.Value = produit.Nom;
            categoryID.Value = produit.Catégorie;
            quantityPerUnit.Value = produit.QteUnitaire;
            unitPrice.Value = produit.PrixUnitaire;
            unitsInStock.Value = produit.UniteEnStock;
            supplierID.Value = produit.Fournisseur; 
            #endregion

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                //on initialise la transaction
                SqlTransaction tran = connect.BeginTransaction();

                #region Ajout des paramètres
                var command = new SqlCommand(sqlQuery, connect, tran);
                command.Parameters.Add(productName);
                command.Parameters.Add(categoryID);
                command.Parameters.Add(quantityPerUnit);
                command.Parameters.Add(unitPrice);
                command.Parameters.Add(unitsInStock);
                command.Parameters.Add(supplierID); 
                #endregion

                try
                {
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
        static public void InsertProduit(Produit produit, Categorie categorie)
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"INSERT Products (ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID)
                                VALUES (@ProductName, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @SupplierID)";

            #region Définition des paramètres
            var productName = new SqlParameter("@ProductName", DbType.String);
            var categoryID = new SqlParameter("@CategoryID", DbType.Int32);
            var quantityPerUnit = new SqlParameter("@QuantityPerUnit", DbType.String);
            var unitPrice = new SqlParameter("@UnitPrice", DbType.Decimal);
            var unitsInStock = new SqlParameter("@UnitsInStock", DbType.Int16);
            var supplierID = new SqlParameter("@SupplierID", DbType.Int32);

            productName.Value = produit.Nom;
            categoryID.Value = categorie.IDCatégorie;
            quantityPerUnit.Value = produit.QteUnitaire;
            unitPrice.Value = produit.PrixUnitaire;
            unitsInStock.Value = produit.UniteEnStock;
            supplierID.Value = produit.Fournisseur;
            #endregion

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();
                //on initialise la transaction
                SqlTransaction tran = connect.BeginTransaction();
                var command = new SqlCommand(sqlQuery, connect, tran);

                #region Ajouts des paramètres
                command.Parameters.Add(productName);
                command.Parameters.Add(categoryID);
                command.Parameters.Add(quantityPerUnit);
                command.Parameters.Add(unitPrice);
                command.Parameters.Add(unitsInStock);
                command.Parameters.Add(supplierID);
                #endregion

                try
                {
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
        static public void RemoveProduit(Produit produit)
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"DELETE Products
                                WHERE ProductID = @ProductID";

            var productID = new SqlParameter("@ProductID", DbType.Int32);
            productID.Value = produit.IDProduit;
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add(productID);
                connect.Open();
                command.ExecuteNonQuery();
            }
        }
        static public void AddCategorie()
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"INSERT Categories (CategoryName)
                                VALUES (@CategoryName)";

            var CategoryName = new SqlParameter("@CategoryName", DbType.String);
            CategoryName.Value = "Autres produits";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add(CategoryName);
                connect.Open();
                command.ExecuteNonQuery();
            }
        }
        static private void GetListeCatégorieFromReader(List<Categorie> listCategorie, SqlDataReader reader)
        {
            while (reader.Read())
            {
                var categorie = new Categorie();
                categorie.IDCatégorie = (int)reader["CategoryID"];
                categorie.Nom = (string)reader["CategoryName"];
                if (reader["Description"] != DBNull.Value)
                    categorie.Description = (string)reader["Description"];
                listCategorie.Add(categorie);
            }
        }
        static public List<Categorie> GetListeCatégorie()
        {
            var listCategorie = new List<Categorie>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"select CategoryID, CategoryName, Description from Categories";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GetListeCatégorieFromReader(listCategorie, reader);
                }
            }
            return listCategorie;
        }
    }
}
