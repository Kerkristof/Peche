using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbSiteCreate
    {
        private static DbSiteCreate instance = null;
        // Constructeur
        private DbSiteCreate()
        {
        }
        // Renvoie une instance de DbSiteCreate
        public static DbSiteCreate Instance()
        {
            if (instance == null)
            {
                instance = new DbSiteCreate();
            }
            return instance;
        }
        public void SiteCreate(string nom)
        {
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "INSERT INTO site (nom)"+
                             $"VALUES (\"{nom}\")";
            // Enregistre les données dans la table
            cmd.ExecuteNonQuery();
            DbConnect.Instance().connection.Close();
        }
    }
}