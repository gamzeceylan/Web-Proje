using FilmLovers.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLovers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<FilmElestri> FilmElestri { get; set; }
        public DbSet<DiziElestri> DiziElestri { get; set; }
        public DbSet<Dizi> Dizi { get; set; }

        public DbSet<Haber> Haber { get; set; }

        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Roportaj> Roportaj { get; set; }

        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
    }
}
