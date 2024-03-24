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

        static DbServisi()
        {
            //Veritabanının oluşturulduğuna emin ol
            ctx.Database.EnsureCreated();
        }

        public static bool OturumAc(string kullaniciAdi, string parola)
        {
            //Hiç kullanıcı yok ise bir tane oluştur
            if(ctx.Kullanicilar.Count()<=0)
            {
                ctx.Kullanicilar.Add(new TblKullanici() { KullaniciAdi = "admin", Parola = "1234", Ad = "", Soyad = "", Yetki = 0 });
                ctx.SaveChanges();
            }


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
            if(OturumAcanKullanici.Yetki!=YetkiTurleri.Yonetici)
                return new List<TblKullanici>();    

            return ctx.Kullanicilar.ToList();
        }
        public static BindingList<TblKullanici> KullaniciBagliListesi()
        {
            ctx.Kullanicilar.Load();
            return ctx.Kullanicilar.Local.ToBindingList();
        }

        public static void KullaniciSil(TblKullanici kullanici)
        {
            if (OturumAcanKullanici.Yetki == YetkiTurleri.Personel)
                return;

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

        #region Müşteri İşlemleri
        public static List<TblMusteri> MusteriListesi()
        {
            return ctx.Musteriler.ToList();
        }
        public static BindingList<TblMusteri> MusteriBagliListesi()
        {
            ctx.Musteriler.Load();
            return ctx.Musteriler.Local.ToBindingList();
        }
        public static void MusteriEkle(TblMusteri musteri)
        {
            ctx.Musteriler.Add(musteri);
        }
        public static void MusteriSil(TblMusteri musteri)
        {
            ctx.Musteriler.Remove(musteri);
        }
        #endregion
        #region Tedarikçi İşlemleri
        public static List<TblTedarikci> TedarikciListesi()
        {
            return ctx.Tedarikciler.ToList();
        }
        public static BindingList<TblTedarikci> TedarikciBagliListesi()
        {
            ctx.Tedarikciler.Load();
            return ctx.Tedarikciler.Local.ToBindingList();
        }
        public static void TedarikciEkle(TblTedarikci tedarikci)
        {
            ctx.Tedarikciler.Add(tedarikci);
        }
        public static void TedarikciSil(TblTedarikci tedarikci)
        {
            ctx.Tedarikciler.Remove(tedarikci);
        }
        #endregion


        #region Stok Giriş İşlmeleri
        
        public static List<TblStokGiris> StokGirisListesi()
        {
            return ctx.StokGirisler.ToList();
        }

        public static BindingList<TblStokGiris> StokGirisBagliListesi()
        {
            ctx.StokGirisler.Load();
            return ctx.StokGirisler.Local.ToBindingList();
        }

        public static void StokGirisEkle(TblStokGiris giris)
        {
            ctx.StokGirisler.Add(giris);
        }
        public static void StokGirisSil(TblStokGiris giris)
        {
            ctx.StokGirisler.Remove(giris);
        }

        #endregion

        #region Stok Çıkış İşlmeleri

        public static List<TblStokCikis> StokCikisListesi()
        {
            return ctx.StokCikislar.ToList();
        }

        public static BindingList<TblStokCikis> StokCikisBagliListesi()
        {
            ctx.StokCikislar.Load();
            return ctx.StokCikislar.Local.ToBindingList();
        }

        public static void StokCikisEkle(TblStokCikis cikis)
        {
            ctx.StokCikislar.Add(cikis);
        }
        public static void StokCikisSil(TblStokCikis cikis)
        {
            ctx.StokCikislar.Remove(cikis);
        }

        #endregion
    }
}
