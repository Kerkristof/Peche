using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbSpotCreate
    {
        private static DbSpotCreate instance = null;
        // Constructeur
        private DbSpotCreate()
        {
        }
        // Renvoie une instance de DbSpotCreate
        public static DbSpotCreate Instance()
        {
            if (instance == null)
            {
                instance = new DbSpotCreate();
            }
            return instance;
        }
        public void SpotCreate(string nom, string gps, int id_site)
        {
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "INSERT INTO espece (nom,gps,id_site)"+
                             $"VALUES (\"{nom}\",\"{gps}\",{id_site})";
            // Enregistre les données dans la table
            cmd.ExecuteNonQuery();
            DbConnect.Instance().connection.Close();
        }
    }
}