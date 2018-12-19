using System;

namespace SitePeche.Models
{
    public class SpotModel
    {
        public int id {get;set;}
        public string nom {get;set;}
        public string gps {get; set;}
        public int id_site {get;set;}

        public SpotModel(int id, string nom, string gps, int id_site)
        {
            this.id = id;
            this.nom = nom;
            this.gps = gps;
            this.id_site = id_site;
        }
    }
}