using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineDiary.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmAd { get; set; }
        public int? Yil { get; set; }
        public int? Uzunluk { get; set; }
        public double? IMDB_Puan { get; set; }

        public string Konu { get; set; }

        public string Afis { get; set; } // veri tabanından link çekilecek
        public string Fragman { get; set; } // link
        public double YazarPuan { get; set; }

        // kategori id -> pK 
        // kategori -> fk
        // isimler aşağıdıdaki gibi tanımlanacak
        public int KategoriId { get; set; } // kategori FK olarak
        public Kategori Kategori { get; set; }


        // yorumlar ve oyuncular burada tutulmaz. onun için ayrı bir tablo oluşturulur ve ilgili id ler çağırlır. ??

        public int DilId { get; set; }
        public Dil Dil { get; set; }


        public int? UlkeId { get; set; }

        public Ulke Ulke { get; set; }


        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

    }
}
