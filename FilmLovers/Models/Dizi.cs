using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Dizi
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength =3)]
        public string DiziAd { get; set; }
        public int? Yil { get; set; }

        [Required]
        public string Konu { get; set; }
        [Required]
        public string Oyuncular { get; set; }
     
        public string Resim { get; set; }
        [Required]
        public string Dil { get; set; }
       
        public int? SezonSayisi { get; set; }
        public int? ToplamBolumSayisi { get; set; }


    }
}
