using BtkProje.Model.Modeller;
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
        public UcKategoriDetay(TblKategori kategori)
        {
            InitializeComponent();
            VerileriGoster(kategori);

        }

        void VerileriGoster(TblKategori kategori)
        {
            this.kategori = kategori;

            txtKategoriAd.Text = kategori.KategoriAd;
        }

        protected override void OnValidated(EventArgs e)
        {
            kategori.KategoriAd = txtKategoriAd.Text;
        }
    }
}
