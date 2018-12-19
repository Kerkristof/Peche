using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbCessionGetAll
    {
        private static DbCessionGetAll instance = null;
        // Constructeur
        private DbCessionGetAll()
        {
        }
        // Renvoie une instance de DbCession
        public static DbCessionGetAll Instance()
        {
            if (instance == null)
            {
                instance = new DbCessionGetAll();
            }
            return instance;
        }
        public List<CessionModel> CessionGetAll()
        {
            List<CessionModel> cessions = new List<CessionModel>();
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "SELECT cession.*,site.nom" +
                             " FROM cession,site " +
                             " WHERE cession.id_site = site.id";

            // On veut récupérer les données sous forme d'un liste d'objets
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while ( reader.Read())
                {
                    CessionModel cession = new CessionModel(0,"","","",0,"");
                    cession.id = reader.GetInt32(reader.GetOrdinal("id"));
                    cession.meteo = reader.GetString(reader.GetOrdinal("meteo"));
                    cession.maree = reader.GetString(reader.GetOrdinal("maree"));
                    cession.date = Convert.ToString(reader.GetDateTime(reader.GetOrdinal("date"))).Substring(0,10);
                    cession.site_nom = reader.GetString(reader.GetOrdinal("nom"));
                    cessions.Add(cession);
                }
            }
            else 
            {
                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return cessions;
        }
    }
}