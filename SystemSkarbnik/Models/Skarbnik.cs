using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SystemSkarbnik.Models
{
    public class Skarbnik
    {
      
        public int ID { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        [Display(Name = "Klasa")]
        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;
        public ICollection<Zbiorka> Zbiorkas { get; } = new List<Zbiorka>();
        [Display(Name = "Skarbnik")]
        public string SkarbnikUserID { get; set; }
        public IdentityUser? SkarbnikUser { get; set; }
    }
}
