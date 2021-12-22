using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Roportaj
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Konu { get; set; }


        public string Resim { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Konusmaci { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string Yazi { get; set; }



    }
}
