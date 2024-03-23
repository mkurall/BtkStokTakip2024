using BtkProje.Model.Modeller;
using BtkProje.Servis;
using DevExpress.XtraEditors;
using System;
using System.Collections;
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
    public partial class UcKategoriler : UserControl, IBtkVeriSayfasi
    {
        public UcKategoriler()
        {
            InitializeComponent();

            repositoryItemButtonEdit1.ButtonClick += RepositoryItemButtonEdit1_ButtonClick;

            VerileriYukle();
        }

        public void GitIlk()
        {
            var kayit = DbServisi.KategoriListesi().FirstOrDefault();
           
            if(kayit!=null)
            {
                int index = ((IList)gridView1.DataSource).IndexOf(kayit); 
                gridView1.FocusedRowHandle = index >= 0 ? index : 0;
            }
        }

        public void GitOnceki()
        {
            int index = gridView1.FocusedRowHandle;
            index--;

            gridView1.FocusedRowHandle = index >= 0 ? index : 0;
            
        }

        public void GitSon()
        {
            var kayit = DbServisi.KategoriListesi().LastOrDefault();

            if (kayit != null)
            {
                int index = ((IList)gridView1.DataSource).IndexOf(kayit);
                gridView1.FocusedRowHandle = index >= 0 ? index : 0;
            }
        }

        public void GitSonraki()
        {
            int index = gridView1.FocusedRowHandle;
            index++;

            gridView1.FocusedRowHandle = index >= 0 ? index : 0;
        }

        public void Sil()
        {
            TblKategori kategori = gridView1.GetFocusedRow() as TblKategori;

            if(kategori != null)
            {
                DialogResult cevap= XtraMessageBox.Show(kategori.KategoriAd + " adlı kategori silinecek. Emin misiniz?",
                    "Uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(cevap == DialogResult.Yes)
                {
                    DbServisi.KategoriSil(kategori);
                }
            }

        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TblKategori kategori = gridView1.GetFocusedRow() as TblKategori;

            if(kategori != null)
            {
                SayfaKontrol.SayfaAc<UcKategoriDetay>("Kategori Detay", null, true, kategori);
            }
        }

        void VerileriYukle()
        {
            var liste = DbServisi.KategoriBagliListesi();
            gridControl1.DataSource = liste;
        }

    }
}
