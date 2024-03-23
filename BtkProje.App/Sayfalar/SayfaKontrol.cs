using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.App.Sayfalar
{
    public static class SayfaKontrol
    {
        private static XtraTabControl _tabControl;

        static Dictionary<Type, XtraTabPage> sayfalar = new Dictionary<Type, XtraTabPage>();

        public static void TabKontrolAyarla(XtraTabControl tabControl)
        {
            _tabControl = tabControl;
        }
    
        public static void SayfaAc<TSayfa>(string baslik, Image simge, bool tekrarAcilabilir = false, params object[] sayfaParametre)
        {
            Type sayfaTuru = typeof(TSayfa);

            if (!tekrarAcilabilir)
            {
                if (sayfalar.ContainsKey(sayfaTuru))//Sayfa daha önce açılmış mı?
                {
                    XtraTabPage eskiSayfa = sayfalar[sayfaTuru];
                    eskiSayfa.Show();//sayfayı göster ve çık
                    return;
                }
            }

            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = baslik;
            tabPage.ImageOptions.Image = simge;
            tabPage.Tag = sayfaTuru;//*******

            //Sayfa içeriğini oluştur ve ekle
            UserControl icerik = (UserControl)Activator.CreateInstance(sayfaTuru, sayfaParametre);

            tabPage.Controls.Add(icerik);
            icerik.Dock = DockStyle.Fill;

            //Sonrası için sakla, iki kere aynı sayfayı açma
            if (!tekrarAcilabilir)
                sayfalar.Add(sayfaTuru, tabPage);

            _tabControl.TabPages.Add(tabPage);
            tabPage.Show();
        }
        public static void SayfaKapat(XtraTabPage tabPage)
        {
            _tabControl.TabPages.Remove(tabPage);

            if (tabPage.Tag != null)//Cebinde anahtar var
            {
                Type sayfaTuru = (Type)tabPage.Tag;

                sayfalar.Remove(sayfaTuru);
            }
        }
    }
}
