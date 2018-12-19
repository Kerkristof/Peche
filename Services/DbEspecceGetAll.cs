using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using SitePeche.Models;
using SitePeche.Services;

namespace SitePeche.Services
{
    public class DbEspeceGetAll
    {
        private static DbEspeceGetAll instance = null;
        // Constructeur
        private DbEspeceGetAll()
        {
        }
        // Renvoie une instance de DbCession
        public static DbEspeceGetAll Instance()
        {
            if (instance == null)
            {
                instance = new DbEspeceGetAll();
            }
            return instance;
        }
        public List<EspeceModel> EspeceGetAll()
        {
            List<EspeceModel> especes = new List<EspeceModel>();
            // Ouverture de la connexion SQL
            DbConnect.Instance().connection.Open();
            // Création d'une commande SQL
            MySqlCommand cmd = DbConnect.Instance().connection.CreateCommand();
            // Requete SQL
            cmd.CommandText = "SELECT * FROM espece";

            // On veut récupérer les données sous forme d'un liste d'objets
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while ( reader.Read())
                {
                    EspeceModel espece = new EspeceModel(0,"","",0);
                    espece.id = reader.GetInt32(0);
                    espece.nom = reader.GetString(1);
                    espece.nom_alt = (!reader.IsDBNull(2))?reader.GetString(2):"-";
                    espece.taille_min = (!reader.IsDBNull(3))?reader.GetInt32(3):0; 
                    especes.Add(espece);
                }
            }
            else 
            {
                Console.WriteLine("No row found");
            }
            reader.Close();
            DbConnect.Instance().connection.Close();
            return especes;
        }
    }
}