using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }
        public string Icerik { get; set; }
    }
}
