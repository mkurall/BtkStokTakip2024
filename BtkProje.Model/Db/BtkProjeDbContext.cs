using BtkProje.Model.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlite("Data Source = d:\\database.db");
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


            modelBuilder.Entity<TblUrun>()
                .HasMany(x => x.StokCikislar)//TblUrunler modelinde tanımlı
                .WithOne(x => x.Urun) //TblStokCikis modelinde tanımlı
                .HasForeignKey(x => x.UrunId);

            modelBuilder.Entity<TblUrun>()
                .HasMany(x => x.StokGirisler)//TblUrunler modelinde tanımlı
                .WithOne(x => x.Urun) //TblStokGiris modelinde tanımlı
                .HasForeignKey(x => x.UrunId);


            modelBuilder.Entity<TblMusteri>()
                .HasMany(x => x.StokCikislar)//TblMusteri modelinde tanımlı
                .WithOne(x => x.Musteri) //TblStokCikis modelinde tanımlı
                .HasForeignKey(x => x.MusteriId);

            modelBuilder.Entity<TblTedarikci>()
                .HasMany(x => x.StokGirisler)//TblTedarikci modelinde tanımlı
                .WithOne(x => x.Tedarikci) //TblStokGiris modelinde tanımlı
                .HasForeignKey(x => x.TedarikciId);
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


                    if(varlik.Entity is TblKullanici)
                    {
                        string parola = ((TblKullanici)varlik.Entity).Parola;

                        byte[] parolaBytes = Encoding.UTF8.GetBytes(parola);

                        byte[] res =  MD5.HashData(parolaBytes);

                        string sifreliParola = ByteArrayToString(res);

                        ((TblKullanici)varlik.Entity).Parola = sifreliParola;
                    }

                }
                if (varlik.State == EntityState.Modified)
                {
                    ((TemelModel)varlik.Entity).GuncellemeTarihi = DateTime.Now;
                    ((TemelModel)varlik.Entity).GuncelleyenKullanici = kullanici;
                }

            }
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public DbSet<TblKullanici> Kullanicilar { get; set; }
        public DbSet<TblKategori> Kategoriler { get; set; }
        public DbSet<TblBirim> Birimler { get; set; }
        public DbSet<TblUrun> Urunler { get; set; }

        public DbSet<TblMusteri> Musteriler { get; set; }
        public DbSet<TblTedarikci> Tedarikciler { get; set; }
        public DbSet<TblStokGiris> StokGirisler { get; set; }
        public DbSet<TblStokCikis> StokCikislar { get; set; }
    }
}
