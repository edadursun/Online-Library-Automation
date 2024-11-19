using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Kutuphane.DataContext.Entities;
using KitapProje.DataContext.Entities;

namespace KitapProje.DataContext
{
    public class DataDBContext : DbContext
    {
        public DataDBContext() : base("Name=DataDBContext")
        {
        }
        public DbSet<Turler> Turlers { get; set; }
        public DbSet<Yazarlar> Yazarlars { get; set; }
        public DbSet<Yayinevleri> Yayinevleris { get; set; }
        public DbSet<Kitaplar> Kitaplars { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the correct Chinook Database tables
            modelBuilder.Entity<Turler>().ToTable("turler", "public");
            modelBuilder.Entity<Yazarlar>().ToTable("yazarlar", "public");
            modelBuilder.Entity<Yayinevleri>().ToTable("yayinevleri", "public");
            modelBuilder.Entity<Kitaplar>().ToTable("kitaplar", "public");
            modelBuilder.Entity<Yorumlar>().ToTable("yorumlar", "public");



            // Chinook Database for PostgreSQL doesn't auto-increment Ids
            modelBuilder.Conventions
                .Remove<StoreGeneratedIdentityKeyConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
