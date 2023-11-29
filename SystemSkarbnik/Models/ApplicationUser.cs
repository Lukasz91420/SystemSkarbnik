using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SystemSkarbnik.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Podanie imienia jest wymagane aby wyświetlać listę rankingową")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Podanie Nazwiska jest wymagane aby wyświetlać listę rankingową")]
        public string Surname { get; set; }

        public int KlasaID { get; set; }
        public Klasa? Klasa { get; set; } = null!;

    }
}
