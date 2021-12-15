using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class DiziYonetmen
    {
        public int Id { get; set; }

        private int YonetmenId { get; set; }
        public Yonetmen Yonetmen { get; set; }

        private int DiziId { get; set; }
        public Dizi Film { get; set; }
    }
}
