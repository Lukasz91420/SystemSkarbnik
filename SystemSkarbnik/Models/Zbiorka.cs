using System.ComponentModel.DataAnnotations;

namespace SystemSkarbnik.Models
{
    public class Zbiorka
    {
       
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public decimal Kwota { get; set; }
        [Display(Name = "Data od")]
        public DateTime DataOd {  get; set; }
        [Display(Name = "Data do")]
        public DateTime DataDo { get; set; }
        [Display(Name ="Klasa")]
        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;
        [Display(Name = "Skarbnik")]
        public int SkarbnikID { get; set; }
        public Skarbnik? Skarbnik { get; set; } = null!;

        public ICollection<ZbiorkaUczen> ZbiorkaUczen { get; } = new List<ZbiorkaUczen>();
    }
}
