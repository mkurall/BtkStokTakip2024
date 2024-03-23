using BtkProje.Model.Db;
using BtkProje.Model.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Servis
{
    public static class DbServisi
    {
        static BtkProjeDbContext ctx = new BtkProjeDbContext();
        public static TblKullanici OturumAcanKullanici { get; private set; }

        public static bool OturumAc(string kullaniciAdi, string parola)
        {
            TblKullanici kull = ctx.Kullanicilar.
                FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi &&
                x.Parola == parola);

            if (kull != null)//kayıt var ise
            {
                OturumAcanKullanici = kull;
                return true;
            }
            else
                return false;
        }

        public static void Kaydet()
        {
            ctx.TemelVerileriYaz(OturumAcanKullanici);
            ctx.SaveChanges();
        }

        #region Kullanici İşlemleri
        public static List<TblKullanici> KullaniciListesi()
        {
            return ctx.Kullanicilar.ToList();
        }
        public static BindingList<TblKullanici> KullaniciBagliListesi()
        {
            ctx.Kullanicilar.Load();
            return ctx.Kullanicilar.Local.ToBindingList();
        }

        public static void KullaniciSil(TblKullanici kullanici)
        {
            ctx.Kullanicilar.Remove(kullanici);
        }
        #endregion

        #region Kategori İşlmeleri
        public static List<TblKategori> KategoriListesi(bool local=false)
        {
            if (local)
                return ctx.Kategoriler.Local.ToList();

            return ctx.Kategoriler.Include(x=>x.Urunler).ToList();
        }

        public static BindingList<TblKategori> KategoriBagliListesi()
        {
            ctx.Kategoriler.Include(x=>x.Urunler).Load();
            return ctx.Kategoriler.Local.ToBindingList();
        }
        public static void KategoriEkle(TblKategori kategori)
        {
            ctx.Kategoriler.Add(kategori);
        }
        public static void KategoriSil(TblKategori kategori)
        {
            ctx.Kategoriler.Remove(kategori);
        }
        #endregion

        #region Birim İşlemleri
        public static List<TblBirim> BirimListesi()
        {
            return ctx.Birimler.ToList();
        }

        public static BindingList<TblBirim> BirimBagliListesi()
        {
            ctx.Birimler.Load();
            return ctx.Birimler.Local.ToBindingList();
        }
        public static void BirimiEkle(TblBirim birim)
        {
            ctx.Birimler.Add(birim);
        }
        public static void BirimSil(TblBirim birim)
        {
            ctx.Birimler.Remove(birim);
        }
        #endregion

        #region Ürün İşlemleri
        public static List<TblUrun> UrunListesi()
        {
            return ctx.Urunler.ToList();
        }
        public static List<TblUrun> UrunListesi(int kategoriId)
        {
            return ctx.Urunler.Where(x=>x.KategoriId == kategoriId).ToList();
        }
        public static BindingList<TblUrun> UrunBagliListesi()
        {
            ctx.Urunler.Load();
            return ctx.Urunler.Local.ToBindingList();
        }
        public static void UrunEkle(TblUrun urun)
        {
            ctx.Urunler.Add(urun);
        }
        public static void UrunSil(TblUrun urun)
        {
            ctx.Urunler.Remove(urun);
        }
        #endregion
    }
}
