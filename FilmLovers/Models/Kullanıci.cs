using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string KullaniciAdi { get; set; }

        [EmailAddress]
        public string EmailAdres { get; set; }

        [Required]
        [Display(Name = "Sifre")]
        public string Sifre { get; set; }

        [Compare("Sifre", ErrorMessage ="Şifreler Eşleşmiyor")]
        public string SifreTekrar { get; set; }

    }
}
