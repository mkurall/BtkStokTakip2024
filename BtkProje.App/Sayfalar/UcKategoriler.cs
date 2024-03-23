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
    public partial class UcKategoriler : UserControl
    {
        public UcKategoriler()
        {
            InitializeComponent();

            repositoryItemButtonEdit1.ButtonClick += RepositoryItemButtonEdit1_ButtonClick;

            VerileriYukle();
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
