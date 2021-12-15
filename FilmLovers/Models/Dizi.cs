﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Dizi
    {
        public int Id { get; set; }
        public string DiziAd { get; set; }
        public string Konu { get; set; }
        public string Resim { get; set; }

        public int? Yil { get; set; }
        public double YazarPuan { get; set; }
        public string Oyuncular { get; set; }

        public int DilId { get; set; }
        public Dil Dil { get; set; }

        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

    }
}