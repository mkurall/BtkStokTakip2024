﻿namespace BtkProje.App
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            bbiYeni = new DevExpress.XtraBars.BarButtonItem();
            bbiIlkKayit = new DevExpress.XtraBars.BarButtonItem();
            bbiOncekiKayit = new DevExpress.XtraBars.BarButtonItem();
            bbiSonrakiKayit = new DevExpress.XtraBars.BarButtonItem();
            bbiSonKayit = new DevExpress.XtraBars.BarButtonItem();
            bbiSil = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            nbiKullanicilar = new DevExpress.XtraNavBar.NavBarItem();
            nbiAyarlar = new DevExpress.XtraNavBar.NavBarItem();
            nbiParametreler = new DevExpress.XtraNavBar.NavBarItem();
            navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            nbiKategoriler = new DevExpress.XtraNavBar.NavBarItem();
            navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            nbiUrunListesi = new DevExpress.XtraNavBar.NavBarItem();
            navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, bbiKaydet, bbiYeni, bbiIlkKayit, bbiOncekiKayit, bbiSonrakiKayit, bbiSonKayit, bbiSil });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 8;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1048, 183);
            ribbonControl1.StatusBar = ribbonStatusBar1;
            // 
            // bbiKaydet
            // 
            bbiKaydet.Caption = "Kaydet";
            bbiKaydet.Id = 1;
            bbiKaydet.ImageOptions.Image = Properties.Resources.save_16x16;
            bbiKaydet.ImageOptions.LargeImage = Properties.Resources.save_32x32;
            bbiKaydet.Name = "bbiKaydet";
            bbiKaydet.ItemClick += bbiKaydet_ItemClick;
            // 
            // bbiYeni
            // 
            bbiYeni.Caption = "Yeni Kayıt";
            bbiYeni.Id = 2;
            bbiYeni.ImageOptions.Image = Properties.Resources.new_16x16;
            bbiYeni.ImageOptions.LargeImage = Properties.Resources.new_32x32;
            bbiYeni.Name = "bbiYeni";
            bbiYeni.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbiIlkKayit
            // 
            bbiIlkKayit.Caption = "İlk Kayıt";
            bbiIlkKayit.Id = 3;
            bbiIlkKayit.ImageOptions.Image = Properties.Resources.first_16x16;
            bbiIlkKayit.ImageOptions.LargeImage = Properties.Resources.first_32x32;
            bbiIlkKayit.Name = "bbiIlkKayit";
            bbiIlkKayit.ItemClick += bbiIlkKayit_ItemClick;
            // 
            // bbiOncekiKayit
            // 
            bbiOncekiKayit.Caption = "Önceki";
            bbiOncekiKayit.Id = 4;
            bbiOncekiKayit.ImageOptions.Image = Properties.Resources.prev_16x16;
            bbiOncekiKayit.ImageOptions.LargeImage = Properties.Resources.prev_32x32;
            bbiOncekiKayit.Name = "bbiOncekiKayit";
            bbiOncekiKayit.ItemClick += bbiOncekiKayit_ItemClick;
            // 
            // bbiSonrakiKayit
            // 
            bbiSonrakiKayit.Caption = "Sonraki";
            bbiSonrakiKayit.Id = 5;
            bbiSonrakiKayit.ImageOptions.Image = Properties.Resources.next_16x16;
            bbiSonrakiKayit.ImageOptions.LargeImage = Properties.Resources.next_32x32;
            bbiSonrakiKayit.Name = "bbiSonrakiKayit";
            bbiSonrakiKayit.ItemClick += bbiSonrakiKayit_ItemClick;
            // 
            // bbiSonKayit
            // 
            bbiSonKayit.Caption = "Son Kayıt";
            bbiSonKayit.Id = 6;
            bbiSonKayit.ImageOptions.Image = Properties.Resources.last_16x16;
            bbiSonKayit.ImageOptions.LargeImage = Properties.Resources.last_32x32;
            bbiSonKayit.Name = "bbiSonKayit";
            bbiSonKayit.ItemClick += bbiSonKayit_ItemClick;
            // 
            // bbiSil
            // 
            bbiSil.Caption = "Sil";
            bbiSil.Id = 7;
            bbiSil.ImageOptions.Image = Properties.Resources.deletelist2_16x16;
            bbiSil.ImageOptions.LargeImage = Properties.Resources.deletelist2_32x32;
            bbiSil.Name = "bbiSil";
            bbiSil.ItemClick += bbiSil_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Giriş";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(bbiKaydet);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Genel";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(bbiYeni);
            ribbonPageGroup2.ItemLinks.Add(bbiIlkKayit);
            ribbonPageGroup2.ItemLinks.Add(bbiOncekiKayit);
            ribbonPageGroup2.ItemLinks.Add(bbiSonrakiKayit);
            ribbonPageGroup2.ItemLinks.Add(bbiSonKayit);
            ribbonPageGroup2.ItemLinks.Add(bbiSil);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Veri";
            // 
            // ribbonStatusBar1
            // 
            ribbonStatusBar1.Location = new Point(0, 567);
            ribbonStatusBar1.Name = "ribbonStatusBar1";
            ribbonStatusBar1.Ribbon = ribbonControl1;
            ribbonStatusBar1.Size = new Size(1048, 33);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 183);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(navBarControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(xtraTabControlMain);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1048, 384);
            splitContainerControl1.SplitterPosition = 294;
            splitContainerControl1.TabIndex = 2;
            // 
            // navBarControl1
            // 
            navBarControl1.ActiveGroup = navBarGroup1;
            navBarControl1.Appearance.Item.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            navBarControl1.Appearance.Item.Options.UseFont = true;
            navBarControl1.Appearance.ItemHotTracked.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            navBarControl1.Appearance.ItemHotTracked.Options.UseFont = true;
            navBarControl1.Dock = DockStyle.Fill;
            navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroup1, navBarGroup2, navBarGroup3, navBarGroup4, navBarGroup5 });
            navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] { nbiKullanicilar, nbiAyarlar, nbiKategoriler, nbiUrunListesi, nbiParametreler });
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.OptionsNavPane.ExpandedWidth = 294;
            navBarControl1.Size = new Size(294, 384);
            navBarControl1.TabIndex = 0;
            navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            navBarGroup1.Caption = "Temel İşlemler";
            navBarGroup1.Expanded = true;
            navBarGroup1.ImageOptions.SmallImage = Properties.Resources.properties_32x32;
            navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(nbiKullanicilar), new DevExpress.XtraNavBar.NavBarItemLink(nbiAyarlar), new DevExpress.XtraNavBar.NavBarItemLink(nbiParametreler) });
            navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiKullanicilar
            // 
            nbiKullanicilar.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbiKullanicilar.Appearance.Options.UseFont = true;
            nbiKullanicilar.Caption = "Kullanıcılar";
            nbiKullanicilar.ImageOptions.SmallImage = Properties.Resources.usergroup_32x32;
            nbiKullanicilar.Name = "nbiKullanicilar";
            nbiKullanicilar.LinkClicked += nbiKullanicilar_LinkClicked;
            // 
            // nbiAyarlar
            // 
            nbiAyarlar.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nbiAyarlar.Appearance.Options.UseFont = true;
            nbiAyarlar.Caption = "Ayarlar";
            nbiAyarlar.ImageOptions.SmallImage = Properties.Resources.version_32x32;
            nbiAyarlar.Name = "nbiAyarlar";
            nbiAyarlar.LinkClicked += nbiAyarlar_LinkClicked;
            // 
            // nbiParametreler
            // 
            nbiParametreler.Caption = "Parametreler";
            nbiParametreler.ImageOptions.SmallImage = Properties.Resources.iconsetredtoblack4_32x32;
            nbiParametreler.Name = "nbiParametreler";
            nbiParametreler.LinkClicked += nbiParametreler_LinkClicked;
            // 
            // navBarGroup2
            // 
            navBarGroup2.Caption = "Ürün Kategorileri";
            navBarGroup2.Expanded = true;
            navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(nbiKategoriler) });
            navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiKategoriler
            // 
            nbiKategoriler.Caption = "Kategoriler";
            nbiKategoriler.ImageOptions.LargeImage = Properties.Resources.solidorangedatabar_32x32;
            nbiKategoriler.ImageOptions.SmallImage = Properties.Resources.solidorangedatabar_32x32;
            nbiKategoriler.Name = "nbiKategoriler";
            nbiKategoriler.LinkClicked += nbiKategoriler_LinkClicked;
            // 
            // navBarGroup3
            // 
            navBarGroup3.Caption = "Ürünler";
            navBarGroup3.Expanded = true;
            navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(nbiUrunListesi) });
            navBarGroup3.Name = "navBarGroup3";
            // 
            // nbiUrunListesi
            // 
            nbiUrunListesi.Caption = "Ürün Listesi";
            nbiUrunListesi.Name = "nbiUrunListesi";
            nbiUrunListesi.LinkClicked += nbiUrunListesi_LinkClicked;
            // 
            // navBarGroup4
            // 
            navBarGroup4.Caption = "Tedarikçiler";
            navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroup5
            // 
            navBarGroup5.Caption = "Müşteriler";
            navBarGroup5.Name = "navBarGroup5";
            // 
            // xtraTabControlMain
            // 
            xtraTabControlMain.AppearancePage.Header.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            xtraTabControlMain.AppearancePage.Header.Options.UseFont = true;
            xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            xtraTabControlMain.Dock = DockStyle.Fill;
            xtraTabControlMain.Location = new Point(0, 0);
            xtraTabControlMain.Name = "xtraTabControlMain";
            xtraTabControlMain.Size = new Size(742, 384);
            xtraTabControlMain.TabIndex = 0;
            xtraTabControlMain.CloseButtonClick += xtraTabControlMain_CloseButtonClick;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 600);
            Controls.Add(splitContainerControl1);
            Controls.Add(ribbonControl1);
            Controls.Add(ribbonStatusBar1);
            Name = "frmAna";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Shown += frmAna_Shown;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiKaydet;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiKullanicilar;
        private DevExpress.XtraNavBar.NavBarItem nbiAyarlar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraBars.BarButtonItem bbiYeni;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbiKategoriler;
        private DevExpress.XtraNavBar.NavBarItem nbiUrunListesi;
        private DevExpress.XtraNavBar.NavBarItem nbiParametreler;


        private DevExpress.XtraBars.BarButtonItem bbiIlkKayit;
        private DevExpress.XtraBars.BarButtonItem bbiOncekiKayit;
        private DevExpress.XtraBars.BarButtonItem bbiSonrakiKayit;
        private DevExpress.XtraBars.BarButtonItem bbiSonKayit;
        private DevExpress.XtraBars.BarButtonItem bbiSil;
    }
}
