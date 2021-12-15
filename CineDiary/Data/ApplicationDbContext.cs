using CineDiary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<Dil> Dil { get; set; }
        public DbSet<Dizi> Dizi { get; set; }
        public DbSet<DiziOyuncu> DiziOyuncu { get; set; }
        public DbSet<FilmYonetmen> FilmYonetmen { get; set; }
        public DbSet<Haber> Haber { get; set; }
        public DbSet<FilmOyuncu> FilmOyuncu { get; set; }
        public DbSet<DiziYonetmen> DiziYonetmen { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Roportaj> Roportaj { get; set; }
      
        public DbSet<Oyuncu> Oyuncu { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
    }
}
