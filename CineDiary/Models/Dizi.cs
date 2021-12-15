using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class Dizi
    {
        public int Id { get; set; }
        public string DiziAd { get; set; }
        public string Konu { get; set; }
        public int? SezonSayisi { get; set; }
        public int? ToplamBolumSayisi { get; set; }
        public int? Yil { get; set; }
        public double YazarPuan { get; set; }

        public int DilId { get; set; }
        public Dil Dil { get; set; }

        public int? UlkeId { get; set; }

        public Ulke Ulke { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

    }
}
