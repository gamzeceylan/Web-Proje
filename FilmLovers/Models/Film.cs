using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1,MinimumLength =50)]
        public string FilmAd { get; set; }
        public int? Yil { get; set; }
        public int? Uzunluk { get; set; }
        public double? IMDB_Puan { get; set; }

        [Required]
        public string Oyuncular { get; set; }

        [Required]
        public string Afis { get; set; }
        public string Dil { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime GosterimBaslangıc { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime GosterimBitis { get; set; }
        public string Konu { get; set; }

        [Required]
        public int KategoriId { get; set; } // kategori FK olarak
        public Kategori Kategori { get; set; }
    }
}
