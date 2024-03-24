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
    public partial class UcStokGiris : UserControl
    {
        public UcStokGiris()
        {
            InitializeComponent();

            VerileriYukle();

        }

        void VerileriYukle()
        {
            lookUpEditUrun.Properties.DataSource = DbServisi.UrunBagliListesi();
            lookUpEditTedarikci.Properties.DataSource = DbServisi.TedarikciBagliListesi();
            
            
            
            repositoryItemLookUpEditUrun.DataSource = DbServisi.UrunBagliListesi();
            repositoryItemLookUpEditTedarikci.DataSource = DbServisi.TedarikciBagliListesi();
            
            
            gridControl1.DataSource = DbServisi.StokGirisBagliListesi();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(lookUpEditUrun.EditValue == null||
                lookUpEditTedarikci.EditValue == null)
            {
                XtraMessageBox.Show("Eksik bilgi girdiniz!","Uyarı",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TblStokGiris giris = new TblStokGiris()
            {
                UrunId = (int)lookUpEditUrun.EditValue,
                TedarikciId = (int)lookUpEditTedarikci.EditValue,
                BirimFiyat = Convert.ToDouble(spinEditBirimFiyat.EditValue),
                Miktar = Convert.ToDouble(spinEditMiktar.EditValue),
                Tarih = (DateTime)dateEditGirisTarihi.EditValue
            };

            DbServisi.StokGirisEkle(giris);
        }
    }
}
