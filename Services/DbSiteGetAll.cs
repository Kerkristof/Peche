using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbSiteGetAll
    {
        private static DbSiteGetAll instance = null;
        // Constructeur
        private DbSiteGetAll()
        {
        }
        // Renvoie une instance de DbCession
        public static DbSiteGetAll Instance()
        {
            if (instance == null)
            {
                instance = new DbSiteGetAll();
            }
            return instance;
        }
        public List<SiteModel> SiteGetAll()
        {
            List<SiteModel> sites = new List<SiteModel>();
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "SELECT * FROM site";

            // On veut récupérer les données sous forme d'un liste d'objets
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while ( reader.Read())
                {
                    SiteModel site = new SiteModel(0,"");
                    site.id = reader.GetInt32(reader.GetOrdinal("id"));
                    site.nom = reader.GetString(reader.GetOrdinal("nom"));
                    sites.Add(site);
                }
            }
            else 
            {
                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return sites;
        }
    }
}