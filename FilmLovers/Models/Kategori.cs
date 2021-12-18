using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Kategori
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş geçilemez")]
        public string KategorAd { get; set; }
    }
}
