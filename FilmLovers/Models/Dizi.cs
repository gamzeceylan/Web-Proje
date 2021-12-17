using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Dizi
    {
        public int Id { get; set; }
        public string DiziAd { get; set; }
        public int? Yil { get; set; }
        public string Konu { get; set; }
        public string Oyuncular { get; set; }
        public string Resim { get; set; }
        public string Dil { get; set; }
       
        public int? SezonSayisi { get; set; }
        public int? ToplamBolumSayisi { get; set; }


    }
}
