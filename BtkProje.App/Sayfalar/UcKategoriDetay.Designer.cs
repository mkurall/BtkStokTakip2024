namespace BtkProje.App.Sayfalar
{
    partial class UcKategoriDetay
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUrunKod = new DevExpress.XtraGrid.Columns.GridColumn();
            colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colMinStok = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            colMaksStok = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)txtKategoriAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSpinEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(18, 23);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(69, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kategori Adı";
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(105, 20);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(210, 22);
            txtKategoriAd.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 54);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEdit1, repositoryItemSpinEdit1 });
            gridControl1.Size = new Size(856, 563);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUrunKod, colUrunAd, colAciklama, colBirimId, colMinStok, colMaksStok });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
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
            // colAciklama
            // 
            colAciklama.Caption = "Açıklama";
            colAciklama.FieldName = "Aciklama";
            colAciklama.MinWidth = 25;
            colAciklama.Name = "colAciklama";
            colAciklama.Visible = true;
            colAciklama.VisibleIndex = 2;
            colAciklama.Width = 94;
            // 
            // colBirimId
            // 
            colBirimId.Caption = "Birimi";
            colBirimId.ColumnEdit = repositoryItemLookUpEdit1;
            colBirimId.FieldName = "BirimId";
            colBirimId.MinWidth = 25;
            colBirimId.Name = "colBirimId";
            colBirimId.Visible = true;
            colBirimId.VisibleIndex = 3;
            colBirimId.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAd", "Birim Adı") });
            repositoryItemLookUpEdit1.DisplayMember = "BirimAd";
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // colMinStok
            // 
            colMinStok.Caption = "Min Stok";
            colMinStok.ColumnEdit = repositoryItemSpinEdit1;
            colMinStok.FieldName = "MinStok";
            colMinStok.MinWidth = 25;
            colMinStok.Name = "colMinStok";
            colMinStok.Visible = true;
            colMinStok.VisibleIndex = 4;
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
            colMaksStok.VisibleIndex = 5;
            colMaksStok.Width = 94;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(txtKategoriAd);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(856, 54);
            panelControl1.TabIndex = 3;
            // 
            // UcKategoriDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "UcKategoriDetay";
            Size = new Size(856, 617);
            ((System.ComponentModel.ISupportInitialize)txtKategoriAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSpinEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKod;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStok;
        private DevExpress.XtraGrid.Columns.GridColumn colMaksStok;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}
