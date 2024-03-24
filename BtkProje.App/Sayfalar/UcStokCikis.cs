using BtkProje.Model.Modeller;
using BtkProje.Servis;
using DevExpress.XtraEditors;
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
    public partial class UcStokCikis : UserControl
    {
        public UcStokCikis()
        {
            InitializeComponent();

            VerileriYukle();

        }

        void VerileriYukle()
        {
            lookUpEditUrun.Properties.DataSource = DbServisi.UrunBagliListesi();
            lookUpEditMusteri.Properties.DataSource = DbServisi.MusteriBagliListesi();
            
            
            
            repositoryItemLookUpEditUrun.DataSource = DbServisi.UrunBagliListesi();
            repositoryItemLookUpEditTedarikci.DataSource = DbServisi.MusteriBagliListesi();


            gridControl1.DataSource = DbServisi.StokCikisBagliListesi();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(lookUpEditUrun.EditValue == null||
                lookUpEditMusteri.EditValue == null)
            {
                XtraMessageBox.Show("Eksik bilgi girdiniz!","Uyarı",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TblStokCikis cikis = new TblStokCikis()
            {
                UrunId = (int)lookUpEditUrun.EditValue,
                MusteriId = (int)lookUpEditMusteri.EditValue,
                BirimFiyat = Convert.ToDouble(spinEditBirimFiyat.EditValue),
                Miktar = Convert.ToDouble(spinEditMiktar.EditValue),
                Tarih = (DateTime)dateEditGirisTarihi.EditValue
            };

            DbServisi.StokCikisEkle(cikis);
        }
    }
}
