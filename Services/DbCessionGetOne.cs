using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbCessionGetOne
    {
        private static DbCessionGetOne instance = null;
        // Constructeur
        private DbCessionGetOne()
        {
        }
        // Renvoie une instance de DbCession
        public static DbCessionGetOne Instance()
        {
            if (instance == null)
            {
                instance = new DbCessionGetOne();
            }
            return instance;
        }
        public CessionModel CessionGetOne(int id)
        {
            CessionModel cession = new CessionModel(0,"","","",0,"");
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = $"SELECT cession.*,site.nom FROM cession,site " +
                                $"WHERE cession.id = {id} AND cession.id_site = site.id";
                                
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while ( reader.Read())
                {
                    cession.id = reader.GetInt32(0);
                    cession.meteo = reader.GetString(1);
                    cession.maree = reader.GetString(2);
                    cession.site_nom = reader.GetString(5);
                }
            } else 
            {
;                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return cession;
        }
    }
}