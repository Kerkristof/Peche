using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbEspeceCreate
    {
        private static DbEspeceCreate instance = null;
        // Constructeur
        private DbEspeceCreate()
        {
        }
        // Renvoie une instance de DbCession
        public static DbEspeceCreate Instance()
        {
            if (instance == null)
            {
                instance = new DbEspeceCreate();
            }
            return instance;
        }
        public void EspeceCreate(string nom, string nom_alt, int taille_min)
        {
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "INSERT INTO espece (nom,nom_alt,taille_min)"+
                             $"VALUES (\"{nom}\",\"{nom_alt}\",{taille_min})";
            // Enregistre les données dans la table
            cmd.ExecuteNonQuery();
            DbConnect.Instance().connection.Close();
        }
    }
}