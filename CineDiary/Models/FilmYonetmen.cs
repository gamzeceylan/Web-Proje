using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class FilmYonetmen
    {
        public int Id { get; set; }

        private int YonetmenId { get; set; }
        public Yonetmen Yonetmen { get; set; }

        private int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
