using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SystemSkarbnik.Models
{
    public class Uczen
    {
        
        public int ID { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        [Display(Name = "Klasa")]
        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;
        public ICollection<ZbiorkaUczen> ZbiorkaUczens { get; } = new List<ZbiorkaUczen>();
        [Display(Name = "Uczeń")]
        public string UczenUserID { get; set; }
        public IdentityUser? UczenUser { get; set; }

    }
}
