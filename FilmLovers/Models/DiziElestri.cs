using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class DiziElestri
    {
        public int Id { get; set; }
        public int DiziId { get; set; }
        public Dizi Dizi { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public string Yazi { get; set; }
        public double YazarPuan { get; set; }

    }
}
