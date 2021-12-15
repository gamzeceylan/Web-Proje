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
        public string FilmAd { get; set; }
        public int? Yil { get; set; }
        public int? Uzunluk { get; set; }
        public double? IMDB_Puan { get; set; }
        public string Oyuncular { get; set; }
        public string Afis { get; set; }

        [DataType(DataType.Date)]
        public DateTime GosterimBaslangıc { get; set; }

        [DataType(DataType.Date)]
        public DateTime GosterimBitis { get; set; }
        public string Konu { get; set; }

        public double YazarPuan { get; set; }

        // kategori id -> pK 
        // kategori -> fk
        // isimler aşağıdıdaki gibi tanımlanacak
        public int KategoriId { get; set; } // kategori FK olarak
        public Kategori Kategori { get; set; }


        // yorumlar ve oyuncular burada tutulmaz. onun için ayrı bir tablo oluşturulur ve ilgili id ler çağırlır. ??

        public int DilId { get; set; }
        public Dil Dil { get; set; }


        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

    }
}
