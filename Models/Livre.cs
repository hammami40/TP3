namespace tp3.Models
{
    public class Livre
    {
        private int id;
        private string isbn;
        private DateTime datepublication;
        private decimal prix;
        private string titre;
        private string auteur;
        private string description;
        private static List<Livre> livres = new List<Livre>();

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Description { get => description; set => description = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public DateTime Datepublication { get => datepublication; set => datepublication = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public static List<Livre> Livres { get => livres; set => livres = value; }

        public Livre(int id, string titre, string auteur, string description, string isbn, DateTime datepublication, decimal prix)
        {
            this.Id = id;
            this.Titre = titre;
            this.Auteur = auteur;
            this.Description = description;
            this.Isbn = isbn;
            this.Datepublication = datepublication;
            this.Prix = prix;
        }

        public override bool Equals(object? obj)
        {
            return obj is Livre livre &&
                   id == livre.id;
        }
    }
}
