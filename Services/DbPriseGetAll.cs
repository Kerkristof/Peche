using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbPriseGetAll
    {
        private static DbPriseGetAll instance = null;
        // Constructeur
        private DbPriseGetAll()
        {
        }
        // Renvoie une instance de DbCession
        public static DbPriseGetAll Instance()
        {
            if (instance == null)
            {
                instance = new DbPriseGetAll();
            }
            return instance;
        }
        public List<PriseModel> PriseGetAll(int id)
        {
            List<PriseModel> prises = new List<PriseModel>();
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = $"SELECT prise.*, espece.nom, spot.* FROM prise, espece, spot " +
                              $"WHERE prise.id_cession = {id} AND prise.id_espece = espece.id AND prise.id_spot = spot.id";

            // On veut récupérer les données sous forme d'un liste d'objets
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PriseModel prise = new PriseModel(0,0,true,0,0,"","",0,"","");
                    prise.nom_espece = reader.GetString(6);
                    prise.taille = reader.GetInt32(1);
                    prise.preleve = reader.GetBoolean(2);
                    prise.nom_spot = reader.GetString(8);
                    prise.gps_spot = reader.GetString(9);
                    prises.Add(prise);
                }
            }
            else
            {
                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return prises;
        }
    }
}