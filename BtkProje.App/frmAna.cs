using BtkProje.App.Sayfalar;
using BtkProje.Servis;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System.Diagnostics;

namespace BtkProje.App
{
    public partial class frmAna : XtraForm
    {
        public frmAna()
        {
            InitializeComponent();

            SayfaKontrol.TabKontrolAyarla(xtraTabControlMain);
        }

        private void frmAna_Shown(object sender, EventArgs e)
        {
            frmGiris form = new frmGiris();

            if (form.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                //Oturum açtýktan sonra ne istersiniz yazýn
                bbiKullanici.Caption = DbServisi.OturumAcanKullanici.KullaniciAdi;
            }
        }

        private void nbiKullanicilar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //TSayfa == UcKullanicilar Türünde
            SayfaKontrol.SayfaAc<UcKullanicilar>("Kullanýcýlar", Properties.Resources.usergroup_32x32, true);
        }

        private void nbiAyarlar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcAyarlar>("Ayarlar", Properties.Resources.properties_32x32);
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs ea2 = (ClosePageButtonEventArgs)e;

            SayfaKontrol.SayfaKapat((XtraTabPage)ea2.Page);
        }

        private void xtraTabPage1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Validate();

            DbServisi.Kaydet();

            XtraMessageBox.Show("Veriler kayýt edildi.", "Bilgi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nbiKategoriler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcKategoriler>("Kategoriler", Properties.Resources.solidorangedatabar_32x32);
        }

        private void nbiUrunListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcUrunler>("Ürünler", null);
        }

        private void nbiParametreler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcParametreler>("Parametreler", Properties.Resources
                .iconsetredtoblack4_32x32
                );
        }


        UserControl AktifSayfaGetir()
        {
            XtraTabPage tabPage =
                xtraTabControlMain.SelectedTabPage;

            if (tabPage != null)
            {
                if (tabPage.Controls.Count > 0)
                    return tabPage.Controls[0] as UserControl;
            }

            return null;
        }

        private void bbiIlkKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl uc = AktifSayfaGetir();

            IBtkVeriSayfasi veri = uc as IBtkVeriSayfasi;

            if (veri != null)
            {
                veri.GitIlk();
            }
        }

        private void bbiOncekiKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl uc = AktifSayfaGetir();

            IBtkVeriSayfasi veri = uc as IBtkVeriSayfasi;

            if (veri != null)
            {
                veri.GitOnceki();
            }
        }

        private void bbiSonrakiKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl uc = AktifSayfaGetir();

            IBtkVeriSayfasi veri = uc as IBtkVeriSayfasi;

            if (veri != null)
            {
                veri.GitSonraki();
            }
        }

        private void bbiSonKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl uc = AktifSayfaGetir();

            IBtkVeriSayfasi veri = uc as IBtkVeriSayfasi;

            if (veri != null)
            {
                veri.GitSon();
            }
        }

        private void bbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControl uc = AktifSayfaGetir();

            IBtkVeriSayfasi veri = uc as IBtkVeriSayfasi;

            if (veri != null)
            {
                veri.Sil();
            }
        }

        private void nbiTedarikciler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcTedarikciler>("Tedarikçiler", Properties.Resources.employee_32x32);

        }

        private void nbiMusteriler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcMusteriler>("Müþteriler", Properties.Resources.boperson_32x32);

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void bsiOturumKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            popupMenu1.HidePopup();
            frmGiris form = new frmGiris();

            if (form.ShowDialog() == DialogResult.OK)
            {
                bbiKullanici.Caption = DbServisi.OturumAcanKullanici.KullaniciAdi;
            }
        }

        private void bsiBtkLink_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.btkakademi.gov.tr") { UseShellExecute = true });
        }

        private void nbiStokGiris_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcStokGiris>("Stok Giriþi", null, true);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaKontrol.SayfaAc<UcStokCikis>("Stok Çýkýþý", null, true);
        }
    }
}
