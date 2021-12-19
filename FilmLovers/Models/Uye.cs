
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// uye -> uyeler (kullanıcılala karışmasın diye böyle dedim. kullanıcıları silicem)
namespace FilmLovers.Models
{
    // asp.net.user tablosyla kalıtım ile bağlantı sağlıyoeuz
    // tabloda olmayan alanlar kendimiz ekliyoruz
    public class Uye : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
