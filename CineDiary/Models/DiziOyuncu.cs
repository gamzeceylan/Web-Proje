using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class DiziOyuncu
    {
        public int Id { get; set; }

        public int? Sira { get; set; } // 1: başrol, 2: yan
        public int OyuncuId { get; set; }
        public Oyuncu Oyuncu { get; set; }

        public int DiziId { get; set; }
        public Dizi Dizi { get; set; }
    }
}
