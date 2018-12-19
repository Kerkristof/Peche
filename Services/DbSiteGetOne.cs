using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbSiteGetOne
    {
        private static DbSiteGetOne instance = null;
        // Constructeur
        private DbSiteGetOne()
        {
        }
        // Renvoie une instance de Dbsite
        public static DbSiteGetOne Instance()
        {
            if (instance == null)
            {
                instance = new DbSiteGetOne();
            }
            return instance;
        }
        public SiteModel SiteGetOne(int id)
        {
            SiteModel site = new SiteModel(0,"");
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = $"SELECT site.*FROM site WHERE site.id = {id}";
                                
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while ( reader.Read())
                {
                    site.id = reader.GetInt32(0);
                    site.nom = reader.GetString(1);
                }
            } else 
            {
;                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return site;
        }
    }
}