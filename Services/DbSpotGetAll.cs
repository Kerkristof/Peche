using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbSpotGetAll
    {
        private static DbSpotGetAll instance = null;
        // Constructeur
        private DbSpotGetAll()
        {
        }
        // Renvoie une instance de DbCession
        public static DbSpotGetAll Instance()
        {
            if (instance == null)
            {
                instance = new DbSpotGetAll();
            }
            return instance;
        }
        public List<SpotModel> SpotGetAll(int id)
        {
            List<SpotModel> spots = new List<SpotModel>();
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = $"SELECT spot.* FROM spot WHERE id_site = {id}";

            // On veut récupérer les données sous forme d'un liste d'objets
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SpotModel spot = new SpotModel(0,"","",0);
                    spot.id = reader.GetInt32(0);
                    spot.nom = reader.GetString(1);
                    spot.gps = reader.GetString(2);
                    spot.id_site = reader.GetInt32(3);
                    spots.Add(spot);
                }
            }
            else
            {
                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return spots;
        }
    }
}