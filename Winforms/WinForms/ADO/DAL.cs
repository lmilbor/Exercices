﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using ADO.Properties;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace ADO
{
    static public class DAL
    {
        #region Requêtes sur la base de donnée

        #region Remplissage des liste par un reader

        /// <summary>
        /// Remplit la liste de produit passé en paramètre avec le reader.
        /// </summary>
        /// <param name="listProduit"></param>
        /// <param name="reader">Le reader de base de donnée.</param>
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
        /// <summary>
        /// Remplit la liste de catégorie passé en paramètre avec le reader.
        /// </summary>
        /// <param name="listCategorie">Liste de catégories à remplir.</param>
        /// <param name="reader">Le reader de base de donnée.</param>
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
        /// <summary>
        /// Remplit la liste de commande passé en paramètre avec le reader.
        /// </summary>
        /// <param name="listCommande">Liste de commandes à remplir.</param>
        /// <param name="reader">Le reader de base de donnée.</param>
        static private void GetListCommandeFromReader(BindingList<Commande> listCommande, SqlDataReader reader)
        {
            while (reader.Read())
            {
                int iDCommande = (int)reader["OrderID"];

                Commande commande = null;

                #region On regarde dans quelle commande ajouter la prochaine ligne de commande
                if (listCommande.Count == 0 || listCommande[listCommande.Count - 1].IDCommande != iDCommande)
                {
                    commande = new Commande();
                    commande.IDCommande = (int)reader["OrderID"];
                    if (reader["CustomerID"] != DBNull.Value)
                        commande.IDClient = (string)reader["CustomerID"];
                    if (reader["OrderDate"] != DBNull.Value)
                        commande.DateCommande = (DateTime)reader["OrderDate"];
                    commande.LigneCommande = new List<LigneCommande>();
                    listCommande.Add(commande);
                }
                else
                    commande = listCommande[listCommande.Count - 1];
                #endregion

                #region On ajoute la ligne de commande
                LigneCommande lc = new LigneCommande();

                lc.IDProduit = (int)reader["ProductID"];
                lc.PrixUnitaire = (decimal)reader["UnitPrice"];
                lc.Quantité = (short)reader["Quantity"];
                lc.Réduction = (float)reader["Discount"];

                commande.LigneCommande.Add(lc);
                #endregion
            }
        }

        #endregion

        /// <summary>
        /// Retourne la liste de tout les fournisseurs de la base de données.
        /// </summary>
        /// <returns></returns>
        static public List<Fournisseur> GetListFournisseurs()
        {
            List<Fournisseur> listFournisseurs = new List<Fournisseur>();
            // On récupère la chaîne de connexion stockée
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            //On prépare notre requête sql
            string sqlQuery = @"SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country
                                FROM Suppliers";
            // On crée une connexion
            using (var connect = new SqlConnection(connectString))
            {
                //on crée la commande relative à la requête
                var command = new SqlCommand(sqlQuery, connect);
                //on ouvre la connexion
                connect.Open();
                //on exécute la requête
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fournisseur = new Fournisseur();
                        fournisseur.FournisseurID = (int)reader["SupplierID"];
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
        /// <summary>
        /// Retourne la liste de tout les fournisseurs d'un pays de la base de données.
        /// </summary>
        /// <param name="pays"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste de toute les Régions de la base de données.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste des pays des fournisseurs.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne le nombre de produits de tout les fournisseurs d'un pays.
        /// </summary>
        /// <param name="pays"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste des commande efféctuer par un client donné.
        /// </summary>
        /// <param name="ClientID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste des clients, IDClient et nom de l'entreprise.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste des produits sur le marché de la base de donnée.
        /// </summary>
        /// <returns></returns>
        static public BindingList<Produit> GetListProduit()
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"SELECT ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID 
                                FROM Products
                                WHERE Discontinued = 0";
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
        /// <summary>
        /// Retourne la liste de produits d'un fournisseur.
        /// </summary>
        /// <param name="fournisseur"></param>
        /// <returns></returns>
        static public BindingList<Produit> GetListProduit(Fournisseur fournisseur)
        {
            var listProduit = new BindingList<Produit>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"SELECT ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID 
                                FROM Products
                                WHERE Discontinued = 0"; //and SupplierID";
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
        /// <summary>
        /// Retourne la liste des catégories de la base de donnée.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retourne la liste de commande de la base de donnée
        /// </summary>
        /// <returns></returns>
        static public BindingList<Commande> GetListCommande()
        {
            var listCommande = new BindingList<Commande>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string sqlQuery = @"SELECT o.OrderID, CustomerID, OrderDate, ProductID, UnitPrice, Quantity, Discount
                                FROM Orders o
                                INNER JOIN Order_Details od on o.OrderID = od.OrderID
                                ORDER BY o.OrderID";
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GetListCommandeFromReader(listCommande, reader);
                }
            }
            return listCommande;
        }

        #endregion

        #region Modification de la base de donnée

        #region Création des table de modification

        /// <summary>
        /// Création et remplissage d'une table mémoire à partir d'une liste de produits.
        /// </summary>
        /// <param name="listeProduits"></param>
        /// <returns></returns>
        static private DataTable GetDataTableForProduits(List<Produit> listeProduits)
        {
            // Créaton d'une table mémoire
            DataTable table = new DataTable();

            // Création des colonnes Nom et Prenom de type chaîne et ajout à la table
            var colNom = new DataColumn("Nom", typeof(string));
            colNom.AllowDBNull = false;
            table.Columns.Add(colNom);

            table.Columns.Add(new DataColumn("CategorieID", typeof(int)));

            table.Columns.Add(new DataColumn("QteUnitaire", typeof(string)));

            table.Columns.Add(new DataColumn("PrixUnitaire", typeof(decimal)));

            table.Columns.Add(new DataColumn("UniteEnStock", typeof(Int16)));

            table.Columns.Add(new DataColumn("FournisseurID", typeof(int)));

            // Chargement de la liste des personnes dans la table mémoire
            foreach (var p in listeProduits)
            {
                // Création d'une ligne de table
                DataRow ligne = table.NewRow();

                #region Remplissage de la ligne
                ligne["Nom"] = p.Nom;
                // Pour une colonne nullable dans la base,
                // il faut affecter la valeur DBNull à la place de null
                if (p.Catégorie != null)
                    ligne["CategorieID"] = p.Catégorie;
                else ligne["CategorieID"] = DBNull.Value;

                if (p.QteUnitaire != null)
                    ligne["QteUnitaire"] = p.QteUnitaire;
                else ligne["QteUnitaire"] = DBNull.Value;

                if (p.PrixUnitaire != null)
                    ligne["PrixUnitaire"] = p.PrixUnitaire;
                else ligne["PrixUnitaire"] = DBNull.Value;

                if (p.UniteEnStock != null)
                    ligne["UniteEnStock"] = p.UniteEnStock;
                else ligne["UniteEnStock"] = DBNull.Value;

                if (p.Fournisseur != null)
                    ligne["FournisseurID"] = p.Fournisseur;
                else ligne["FournisseurID"] = DBNull.Value;
                #endregion

                // Ajout de la ligne dans la table
                table.Rows.Add(ligne);
            }

            return table;
        }
        /// <summary>
        /// Création et remplissage d'une table mémoire à partir d'une liste de produits.
        /// </summary>
        /// <param name="listeProduits"></param>
        /// <returns></returns>
        static private DataTable GetDataTableForProduitsID(List<Produit> listeProduits)
        {
            // Créaton d'une table mémoire
            DataTable table = new DataTable();

            // Création des colonnes Nom et Prenom de type chaîne et ajout à la table
            var colIDProduit = new DataColumn("IDProduit", typeof(int));
            colIDProduit.AllowDBNull = false;
            table.Columns.Add(colIDProduit);

            // Chargement de la liste des personnes dans la table mémoire
            foreach (var p in listeProduits)
            {
                // Création d'une ligne de table
                DataRow ligne = table.NewRow();

                #region Remplissage de la ligne
                ligne["IDProduit"] = p.IDProduit;
                #endregion

                // Ajout de la ligne dans la table
                table.Rows.Add(ligne);
            }

            return table;
        }

        #endregion

        /// <summary>
        /// Insert un nouveau produit dans la base de donnée.
        /// </summary>
        /// <param name="produit"></param>
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
        /// <summary>
        /// Insert un nouveau produit en précisant une catégorie.
        /// </summary>
        /// <param name="produit"></param>
        /// <param name="categorie"></param>
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
        /// <summary>
        /// Retire un produit de la base de donnée.
        /// </summary>
        /// <param name="produit"></param>
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
        /// <summary>
        /// Ajoute une nouvelle catégorie nommée "Autres produits" dans la base de donnée.
        /// </summary>
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
        /// <summary>
        /// Ajoute de nouveau produits dans la base de donnée à partir d'une liste.
        /// </summary>
        /// <param name="listeProduits">Liste de produits à ajouter</param>
        static public void AjouterProduits(List<Produit> listeProduits)
        {
            // Ecriture de la requête d'insertion en masse
            // Le paramètre @table contiendra les enregistrements à insérer
            string req = @"
                      insert Products (ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID) 
                      select Nom, CategorieID, QteUnitaire, PrixUnitaire, UniteEnStock, FournisseurID from @table";

            // Création du paramètre de type table mémoire
            // /!\ Le type TypeTablePersonne doit être créé au préalable dans la base
            var param = new SqlParameter("@table", SqlDbType.Structured);
            DataTable tableProduits = GetDataTableForProduits(listeProduits);
            param.TypeName = "TypeTableProduit";
            param.Value = tableProduits;

            using (var cnx = new SqlConnection(Settings.Default.NorthwindConnectionString))
            {
                // Ouverture de la connexion et début de la transaction
                cnx.Open();
                SqlTransaction tran = cnx.BeginTransaction();

                try
                {
                    // Création et exécution de la commande
                    var command = new SqlCommand(req, cnx, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    // Validation de la transaction s'il n'y a pas eu d'erreur
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback(); // Annulation de la transaction en cas d'erreur
                    throw;   // Remontée de l'erreur à l'appelant
                }
            }
        }
        /// <summary>
        /// Rend obsolète des produits de la base de donnée à partir d'une liste.
        /// </summary>
        /// <param name="listeProduits">Liste de produits obsolète.</param>
        static public void SupprimerProduits(List<Produit> listeProduits)
        {
            // Ecriture de la requête d'insertion en masse
            // Le paramètre @table contiendra les enregistrements à insérer
            string req = @"
                      UPDATE Products set Discontinued = 1
                      FROM Products p
                      INNER JOIN @TableIDProduits tp on tp.ID = p.ProductID";

            // Création du paramètre de type table mémoire
            // /!\ Le type TypeTablePersonne doit être créé au préalable dans la base
            var param = new SqlParameter("@TableIDProduits", SqlDbType.Structured);
            DataTable tableProduitsID = GetDataTableForProduitsID(listeProduits);
            param.TypeName = "TypeTableId";
            param.Value = tableProduitsID;

            using (var cnx = new SqlConnection(Settings.Default.NorthwindConnectionString))
            {
                // Ouverture de la connexion et début de la transaction
                cnx.Open();
                SqlTransaction tran = cnx.BeginTransaction();

                try
                {
                    // Création et exécution de la commande
                    var command = new SqlCommand(req, cnx, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    // Validation de la transaction s'il n'y a pas eu d'erreur
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback(); // Annulation de la transaction en cas d'erreur
                    throw;   // Remontée de l'erreur à l'appelant
                }
            }
        }

        #endregion

        #region Import - Exoprt

        /// <summary>
        /// Exporte la liste donnée en paramètre sous forme xml et la stock au chemin spécifié.
        /// </summary>
        /// <param name="listeCommande">Liste à sauvegrder</param>
        /// <param name="chemin">chemin du dossier et nom du fichier avec extension.</param>
        static public void ExporterXml(BindingList<Commande> listeCommande, string chemin)
        {
            // On crée un sérialiseur, en spécifiant le type de l'objet à sérialiser
            // et le nom de l'élément xml racine
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Commande>),
                                       new XmlRootAttribute("ListeCommandes"));

            using (var sw = new StreamWriter(chemin))
            {
                serializer.Serialize(sw, listeCommande);
            }
        }
        /// <summary>
        /// Importe une liste dont le chemin est donné en paramètre.
        /// </summary>
        /// <param name="chemin">chemin du fichier xml à importer.</param>
        /// <returns></returns>
        static public BindingList<Commande> ImporterXml(string chemin)
        {
            BindingList<Commande> listeCommande = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<Commande>),
               new XmlRootAttribute("ListeCommandes"));

            using (var sr = new StreamReader(chemin))
            {
                // Deserialize renvoie un type object, qu'il faut transtyper 
                listeCommande = (BindingList<Commande>)deserializer.Deserialize(sr);
            }

            return listeCommande;
        }
        /// <summary>
        /// Exporte la liste donnée en paramètre sous forme xml et la stock au chemin spécifié.
        /// Le fichier de sortie est trié par année et mois et indique l'IDCommande et le cout de celle-ci.
        /// </summary>
        /// <param name="listeCommande"></param>
        /// <param name="chemin"></param>
        static public void ExporterXml_XmlWriter(BindingList<Commande> listeCommande, string chemin)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(chemin, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DatesCommandes");
                var listeTemp = listeCommande.OrderBy(c => c.DateCommande).ToList();
                int année = listeTemp.First().DateCommande.Year;
                int mois = listeTemp.First().DateCommande.Month;
                writer.WriteStartElement("DateCommande");
                writer.WriteAttributeString("annee", listeTemp.First().DateCommande.Year.ToString());
                writer.WriteAttributeString("mois", listeTemp.First().DateCommande.Month.ToString());
                foreach (Commande commande in listeTemp)
                {
                    if (!(commande.DateCommande.Year == année && commande.DateCommande.Month == mois))
                    {
                        writer.WriteEndElement();
                        writer.WriteStartElement("DateCommande");
                        writer.WriteAttributeString("annee", commande.DateCommande.Year.ToString());
                        writer.WriteAttributeString("mois", commande.DateCommande.Month.ToString());
                        année = commande.DateCommande.Year;
                        mois = commande.DateCommande.Month;
                    }
                    writer.WriteStartElement("Commande");
                    writer.WriteAttributeString("Id", commande.IDCommande.ToString());
                    writer.WriteAttributeString("Montant",
                        commande.LigneCommande.Sum(l => l.PrixUnitaire * l.Quantité * (1 - (decimal)l.Réduction)).ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        #endregion

    }
}
