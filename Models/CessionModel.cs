using System;

namespace SitePeche.Models
{
    public class CessionModel
    {
        public int id{get; set;}
        public string meteo{get;set;}
        public string maree{get;set;}
        public string date{get;set;}
        public int site_id{get;set;}
        public string site_nom{set;get;}

        public CessionModel(int id, string meteo, string maree, string date,
        int site_id, string site_nom)
        {
            this.id = id;
            this.meteo = meteo;
            this.maree = maree;
            this.date = date;
            this.site_id = site_id;
            this.site_nom = site_nom;
        }
    }
}