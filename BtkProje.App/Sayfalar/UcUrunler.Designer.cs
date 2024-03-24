namespace BtkProje.App.Sayfalar
{
    partial class UcUrunler
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUrunKod = new DevExpress.XtraGrid.Columns.GridColumn();
            colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEditKategoriler = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEditBirimler = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colMinStok = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            colMaksStok = new DevExpress.XtraGrid.Columns.GridColumn();
            colStok = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditKategoriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditBirimler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSpinEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 63);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEditBirimler, repositoryItemSpinEdit1, repositoryItemLookUpEditKategoriler });
            gridControl1.Size = new Size(899, 510);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUrunKod, colUrunAd, colKategori, colAciklama, colBirimId, colMinStok, colMaksStok, colStok });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            // 
            // colUrunKod
            // 
            colUrunKod.Caption = "Ürün Kodu";
            colUrunKod.FieldName = "UrunKod";
            colUrunKod.MinWidth = 25;
            colUrunKod.Name = "colUrunKod";
            colUrunKod.Visible = true;
            colUrunKod.VisibleIndex = 0;
            colUrunKod.Width = 94;
            // 
            // colUrunAd
            // 
            colUrunAd.Caption = "Ürün Adı";
            colUrunAd.FieldName = "UrunAd";
            colUrunAd.MinWidth = 25;
            colUrunAd.Name = "colUrunAd";
            colUrunAd.Visible = true;
            colUrunAd.VisibleIndex = 1;
            colUrunAd.Width = 94;
            // 
            // colKategori
            // 
            colKategori.Caption = "Kategori";
            colKategori.ColumnEdit = repositoryItemLookUpEditKategoriler;
            colKategori.FieldName = "KategoriId";
            colKategori.MinWidth = 25;
            colKategori.Name = "colKategori";
            colKategori.Visible = true;
            colKategori.VisibleIndex = 2;
            colKategori.Width = 94;
            // 
            // repositoryItemLookUpEditKategoriler
            // 
            repositoryItemLookUpEditKategoriler.AutoHeight = false;
            repositoryItemLookUpEditKategoriler.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditKategoriler.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KategoriAd", "Kategori Adı") });
            repositoryItemLookUpEditKategoriler.DisplayMember = "KategoriAd";
            repositoryItemLookUpEditKategoriler.Name = "repositoryItemLookUpEditKategoriler";
            repositoryItemLookUpEditKategoriler.ValueMember = "Id";
            // 
            // colAciklama
            // 
            colAciklama.Caption = "Açıklama";
            colAciklama.FieldName = "Aciklama";
            colAciklama.MinWidth = 25;
            colAciklama.Name = "colAciklama";
            colAciklama.Visible = true;
            colAciklama.VisibleIndex = 3;
            colAciklama.Width = 94;
            // 
            // colBirimId
            // 
            colBirimId.Caption = "Birimi";
            colBirimId.ColumnEdit = repositoryItemLookUpEditBirimler;
            colBirimId.FieldName = "BirimId";
            colBirimId.MinWidth = 25;
            colBirimId.Name = "colBirimId";
            colBirimId.Visible = true;
            colBirimId.VisibleIndex = 4;
            colBirimId.Width = 94;
            // 
            // repositoryItemLookUpEditBirimler
            // 
            repositoryItemLookUpEditBirimler.AutoHeight = false;
            repositoryItemLookUpEditBirimler.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditBirimler.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAd", "Birim Adı") });
            repositoryItemLookUpEditBirimler.DisplayMember = "BirimAd";
            repositoryItemLookUpEditBirimler.Name = "repositoryItemLookUpEditBirimler";
            repositoryItemLookUpEditBirimler.ValueMember = "Id";
            // 
            // colMinStok
            // 
            colMinStok.Caption = "Min Stok";
            colMinStok.ColumnEdit = repositoryItemSpinEdit1;
            colMinStok.FieldName = "MinStok";
            colMinStok.MinWidth = 25;
            colMinStok.Name = "colMinStok";
            colMinStok.Visible = true;
            colMinStok.VisibleIndex = 5;
            colMinStok.Width = 94;
            // 
            // repositoryItemSpinEdit1
            // 
            repositoryItemSpinEdit1.AutoHeight = false;
            repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemSpinEdit1.MaxValue = new decimal(new int[] { 100, 0, 0, 0 });
            repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colMaksStok
            // 
            colMaksStok.Caption = "Maks Stok";
            colMaksStok.ColumnEdit = repositoryItemSpinEdit1;
            colMaksStok.FieldName = "MaksStok";
            colMaksStok.MinWidth = 25;
            colMaksStok.Name = "colMaksStok";
            colMaksStok.Visible = true;
            colMaksStok.VisibleIndex = 6;
            colMaksStok.Width = 94;
            // 
            // colStok
            // 
            colStok.Caption = "Mevcut Stok";
            colStok.FieldName = "colStok";
            colStok.MinWidth = 25;
            colStok.Name = "colStok";
            colStok.UnboundDataType = typeof(double);
            colStok.Visible = true;
            colStok.VisibleIndex = 7;
            colStok.Width = 94;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnYazdir);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(899, 63);
            panelControl1.TabIndex = 4;
            // 
            // btnYazdir
            // 
            btnYazdir.ImageOptions.Image = Properties.Resources.printer_32x32;
            btnYazdir.Location = new Point(23, 14);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(118, 36);
            btnYazdir.TabIndex = 0;
            btnYazdir.Text = "Yazdır";
            btnYazdir.Click += btnYazdir_Click;
            // 
            // UcUrunler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "UcUrunler";
            Size = new Size(899, 573);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditKategoriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditBirimler).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSpinEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKod;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditKategoriler;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBirimler;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaksStok;
        private DevExpress.XtraGrid.Columns.GridColumn colStok;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
    }
}
