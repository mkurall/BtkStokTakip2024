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
            if(e.IsGetData)
            {
                TblUrun urun = e.Row as TblUrun;

                if(urun != null )
                {
                    double cikisMiktari = DbServisi.StokCikisBagliListesi().Where(x=>x.UrunId == urun.Id).Sum(x => x.Miktar);
                    double girisMiktari = DbServisi.StokGirisBagliListesi().Where(x => x.UrunId == urun.Id).Sum(x => x.Miktar);



                    e.Value = girisMiktari - cikisMiktari;
                }

                
            }
        }
    }
}
