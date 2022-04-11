using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AsiWind;Trusted_Connection=true");

        }
        public DbSet<Asi> Asilar { get; set; }
        public DbSet<AsiIcerik> AsiIcerik { get; set; }
        public DbSet<Cevap> Cevaplar { get; set; }
        public DbSet<Hastalik> Hastaliklar { get; set; }
        public DbSet<Anasayfa> Anasayfa { get; set; }
        public DbSet<Soru> Sorular { get; set; }
        public DbSet<SoruImage> SoruImage { get; set; }
    }
}
