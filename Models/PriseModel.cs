using System;

namespace SitePeche.Models
{
    public class PriseModel
    {
        public int id {get;set;}
        public int taille {get; set;}
        public bool preleve {get; set;}
        public int id_cession {get; set;}
        public int id_espece {get; set;}
        public string nom_espece {get; set;}
        public string nom_alt_espece {get;set;}
        public int id_spot {set; get;}
        public string nom_spot {get;set;}
        public string gps_spot {get;set;}
        public PriseModel(int id, int taille, bool preleve, int id_cession, int id_espece,
        string nom_espece, string nom_alt_espece, int id_spot, string nom_spot, string gps_spot)
        {
            this.id = id;
            this.taille = taille;
            this.preleve = preleve;
            this.id_cession = id_cession;
            this.id_espece = id_espece;
            this.nom_espece = nom_espece;
            this.nom_alt_espece = nom_alt_espece;
            this.id_spot = id_spot;
            this.nom_spot = nom_spot;
            this.gps_spot = gps_spot;
        }
    }
}