using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class FilmElestri
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public string Yazi { get; set; }
        public double YazarPuan { get; set; }
    }
}
