namespace SitePeche.Models
{
    public class EspeceModel
    {
        public int id {get; set;}
        public string nom {get; set;}
        public string nom_alt {get; set;}
        public int taille_min {get; set;}

        public EspeceModel(int id, string nom, string nom_alt, int taille_min)
        {
            this.id = id;
            this.nom = nom;
            this.nom_alt = nom_alt;
            this.taille_min = taille_min;
        }
    }
}