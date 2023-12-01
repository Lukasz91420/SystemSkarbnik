using System.ComponentModel.DataAnnotations;

namespace SystemSkarbnik.Models
{
    public class ZbiorkaUczen
    {
        public int ID { get; set; }
        [Display(Name = "Zbiórka")]
        public int ZbiorkaID { get; set; }
        public Zbiorka? Zbiorka { get; set; } = null!;
        [Display(Name ="Klasa")]
        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;
        [Display(Name = "Uczeń")]
        public int UczenID { get; set; }
        public Uczen? Uczen { get; set; } = null!;
        [Display(Name = "Czy zapłacił")]
        public bool CzyZaplacil { get; set; }
        [Display(Name = "Kiedy zapłacił")]
        public DateTime KiedyZaplacil {  get; set; }
        
    }
}
