using BtkProje.Model.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Db
{
    public class BtkProjeDbContext : DbContext
    {
        private string connectionString;


        //EF Core Tools Bunu(ilk yapıcıyı) kullanacak
        public BtkProjeDbContext()
        {
            this.connectionString = "Server=.\\SQLEXPRESS;Database=btk_stoktakip2024_db;Trusted_Connection=True;Encrypt=False";
        }

        public BtkProjeDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<TemelModel>();

            modelBuilder.Entity<TblUrun>()
                .HasOne(x => x.Kategori)
                .WithMany(x => x.Urunler)
                .HasForeignKey(x => x.KategoriId)
                .IsRequired();

            modelBuilder.Entity<TblUrun>()
                .HasOne(x => x.Birim)
                .WithMany()
                .HasForeignKey(x=>x.BirimId);
        }

        public void TemelVerileriYaz(TblKullanici kullanici)
        {
            var varliklar = ChangeTracker.Entries().Where(e => e.Entity is TemelModel && (
            e.State == EntityState.Added || e.State == EntityState.Modified));


            foreach(var varlik in varliklar)
            {
                if(varlik.State == EntityState.Added)
                {
                    ((TemelModel)varlik.Entity).OlusturmaTarihi = DateTime.Now;
                    ((TemelModel)varlik.Entity).OlusturanKullanici = kullanici;
                }
                if (varlik.State == EntityState.Modified)
                {
                    ((TemelModel)varlik.Entity).GuncellemeTarihi = DateTime.Now;
                    ((TemelModel)varlik.Entity).GuncelleyenKullanici = kullanici;
                }

            }

        }

        public DbSet<TblKullanici> Kullanicilar { get; set; }
        public DbSet<TblKategori> Kategoriler { get; set; }
        public DbSet<TblBirim> Birimler { get; set; }
        public DbSet<TblUrun> Urunler { get; set; }
    }
}
