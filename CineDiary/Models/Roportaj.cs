using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class Roportaj
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Konusmaci { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }


    }
}
