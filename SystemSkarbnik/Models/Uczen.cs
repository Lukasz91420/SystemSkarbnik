namespace SystemSkarbnik.Models
{
    public class Uczen
    {
        public int ID { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;
        public ICollection<ZbiorkaUczen> ZbiorkaUczens { get; } = new List<ZbiorkaUczen>();

    }
}
