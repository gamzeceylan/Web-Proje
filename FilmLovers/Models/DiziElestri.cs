using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class DiziElestri
    {
        public int Id { get; set; }

        [Required]
        public int DiziId { get; set; }
        public Dizi Dizi { get; set; }

        [Required]
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        [Required]
        public string Yazi { get; set; }
        public double YazarPuan { get; set; }

    }
}
