using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class FilmElestri
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public int FilmId { get; set; }
        public Film Film { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Yazi { get; set; }
        public double YazarPuan { get; set; }
    }
}
