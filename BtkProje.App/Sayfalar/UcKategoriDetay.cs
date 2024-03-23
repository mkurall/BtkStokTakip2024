using BtkProje.Model.Modeller;
using BtkProje.Servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkProje.App.Sayfalar
{
    public partial class UcKategoriDetay : UserControl
    {
        TblKategori kategori;

        BindingList<TblUrun> urunlerBindList = new BindingList<TblUrun>();

        public UcKategoriDetay(TblKategori kategori)
        {
            InitializeComponent();

            repositoryItemLookUpEdit1.DataSource = DbServisi.BirimListesi();

            VerileriGoster(kategori);

        }

        void VerileriGoster(TblKategori kategori)
        {
            this.kategori = kategori;

            txtKategoriAd.Text = kategori.KategoriAd;


            var urunler = DbServisi.UrunListesi(kategori.Id);

            urunlerBindList = new BindingList<TblUrun>(urunler);

            gridControl1.DataSource = urunlerBindList;

        }

        protected override void OnValidated(EventArgs e)
        {
            kategori.KategoriAd = txtKategoriAd.Text;


            foreach(TblUrun urun in urunlerBindList)
            {
                kategori.Urunler.Add(urun);

            }

        }
    }
}
