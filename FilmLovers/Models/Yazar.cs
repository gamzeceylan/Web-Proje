using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Yazar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Sifre { get; set; }
        // yazarı sadece admin üye yapabilir

    }
}
