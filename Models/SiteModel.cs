using System;

namespace SitePeche.Models
{
    public class SiteModel
    {
        public int id {get;set;}
        public string nom {get;set;}

        public SiteModel(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}