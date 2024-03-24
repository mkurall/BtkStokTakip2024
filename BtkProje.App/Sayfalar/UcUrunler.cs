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
    public partial class UcUrunler : UserControl
    {
        public UcUrunler()
        {
            InitializeComponent();

            repositoryItemLookUpEditBirimler.DataSource = DbServisi.BirimListesi();

            repositoryItemLookUpEditKategoriler.DataSource = DbServisi.KategoriListesi(true);

            VerileriYukle();
        }

        void VerileriYukle()
        {
            gridControl1.DataSource = DbServisi.UrunBagliListesi();
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                TblUrun urun = e.Row as TblUrun;
                e.Value = DbServisi.MevcutStokHesapla(urun);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}
