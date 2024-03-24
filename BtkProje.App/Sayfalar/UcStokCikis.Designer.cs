namespace BtkProje.App.Sayfalar
{
    partial class UcStokCikis
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
            lookUpEditUrun = new DevExpress.XtraEditors.LookUpEdit();
            lookUpEditMusteri = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            spinEditBirimFiyat = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            spinEditMiktar = new DevExpress.XtraEditors.SpinEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            dateEditGirisTarihi = new DevExpress.XtraEditors.DateEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEditUrun = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colTedarikci = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEditTedarikci = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            coltutar = new DevExpress.XtraGrid.Columns.GridColumn();
            Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)lookUpEditUrun.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditMusteri.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEditBirimFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEditMiktar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditGirisTarihi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditGirisTarihi.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditUrun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditTedarikci).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(34, 20);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(27, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ürün";
            // 
            // lookUpEditUrun
            // 
            lookUpEditUrun.Location = new Point(115, 17);
            lookUpEditUrun.Name = "lookUpEditUrun";
            lookUpEditUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditUrun.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UrunKod", "Ürün Kodu"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UrunAd", "Ürün"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Açıklama") });
            lookUpEditUrun.Properties.DisplayMember = "Bilgi";
            lookUpEditUrun.Properties.ValueMember = "Id";
            lookUpEditUrun.Size = new Size(267, 22);
            lookUpEditUrun.TabIndex = 1;
            // 
            // lookUpEditMusteri
            // 
            lookUpEditMusteri.Location = new Point(115, 63);
            lookUpEditMusteri.Name = "lookUpEditMusteri";
            lookUpEditMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditMusteri.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirmaAd", "Firma") });
            lookUpEditMusteri.Properties.DisplayMember = "Bilgi";
            lookUpEditMusteri.Properties.ValueMember = "Id";
            lookUpEditMusteri.Size = new Size(267, 22);
            lookUpEditMusteri.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(34, 66);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(42, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Müşteri";
            // 
            // spinEditBirimFiyat
            // 
            spinEditBirimFiyat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditBirimFiyat.Location = new Point(115, 103);
            spinEditBirimFiyat.Name = "spinEditBirimFiyat";
            spinEditBirimFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditBirimFiyat.Size = new Size(267, 22);
            spinEditBirimFiyat.TabIndex = 4;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(34, 108);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(60, 16);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Birim Fiyat";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(34, 138);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(35, 16);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Miktar";
            // 
            // spinEditMiktar
            // 
            spinEditMiktar.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditMiktar.Location = new Point(115, 133);
            spinEditMiktar.Name = "spinEditMiktar";
            spinEditMiktar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditMiktar.Size = new Size(267, 22);
            spinEditMiktar.TabIndex = 6;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(34, 180);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(30, 16);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "Tarih";
            // 
            // dateEditGirisTarihi
            // 
            dateEditGirisTarihi.EditValue = null;
            dateEditGirisTarihi.Location = new Point(115, 177);
            dateEditGirisTarihi.Name = "dateEditGirisTarihi";
            dateEditGirisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditGirisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditGirisTarihi.Size = new Size(267, 22);
            dateEditGirisTarihi.TabIndex = 9;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnEkle);
            panelControl1.Controls.Add(lookUpEditUrun);
            panelControl1.Controls.Add(dateEditGirisTarihi);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(labelControl5);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(lookUpEditMusteri);
            panelControl1.Controls.Add(spinEditMiktar);
            panelControl1.Controls.Add(spinEditBirimFiyat);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1010, 229);
            panelControl1.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Appearance.Options.UseFont = true;
            btnEkle.ImageOptions.Image = Properties.Resources.add_32x32;
            btnEkle.Location = new Point(407, 154);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(85, 52);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 229);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEditUrun, repositoryItemLookUpEditTedarikci });
            gridControl1.Size = new Size(1010, 280);
            gridControl1.TabIndex = 11;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUrun, colTedarikci, colBirimFiyat, colMiktar, coltutar, Tarih });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colUrun
            // 
            colUrun.Caption = "Ürün";
            colUrun.ColumnEdit = repositoryItemLookUpEditUrun;
            colUrun.FieldName = "UrunId";
            colUrun.MinWidth = 25;
            colUrun.Name = "colUrun";
            colUrun.Visible = true;
            colUrun.VisibleIndex = 0;
            colUrun.Width = 94;
            // 
            // repositoryItemLookUpEditUrun
            // 
            repositoryItemLookUpEditUrun.AutoHeight = false;
            repositoryItemLookUpEditUrun.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditUrun.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bilgi", "Ürün") });
            repositoryItemLookUpEditUrun.DisplayMember = "Bilgi";
            repositoryItemLookUpEditUrun.Name = "repositoryItemLookUpEditUrun";
            repositoryItemLookUpEditUrun.ValueMember = "Id";
            // 
            // colTedarikci
            // 
            colTedarikci.Caption = "Müşteri";
            colTedarikci.ColumnEdit = repositoryItemLookUpEditTedarikci;
            colTedarikci.FieldName = "MusteriId";
            colTedarikci.MinWidth = 25;
            colTedarikci.Name = "colTedarikci";
            colTedarikci.Visible = true;
            colTedarikci.VisibleIndex = 1;
            colTedarikci.Width = 94;
            // 
            // repositoryItemLookUpEditTedarikci
            // 
            repositoryItemLookUpEditTedarikci.AutoHeight = false;
            repositoryItemLookUpEditTedarikci.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditTedarikci.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bilgi", "Tedarikçi") });
            repositoryItemLookUpEditTedarikci.DisplayMember = "Bilgi";
            repositoryItemLookUpEditTedarikci.Name = "repositoryItemLookUpEditTedarikci";
            repositoryItemLookUpEditTedarikci.ValueMember = "Id";
            // 
            // colBirimFiyat
            // 
            colBirimFiyat.Caption = "Birim Fiyat";
            colBirimFiyat.FieldName = "BirimFiyat";
            colBirimFiyat.MinWidth = 25;
            colBirimFiyat.Name = "colBirimFiyat";
            colBirimFiyat.Visible = true;
            colBirimFiyat.VisibleIndex = 2;
            colBirimFiyat.Width = 94;
            // 
            // colMiktar
            // 
            colMiktar.Caption = "Miktar";
            colMiktar.FieldName = "Miktar";
            colMiktar.MinWidth = 25;
            colMiktar.Name = "colMiktar";
            colMiktar.Visible = true;
            colMiktar.VisibleIndex = 3;
            colMiktar.Width = 94;
            // 
            // coltutar
            // 
            coltutar.AppearanceCell.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            coltutar.AppearanceCell.ForeColor = Color.Red;
            coltutar.AppearanceCell.Options.UseFont = true;
            coltutar.AppearanceCell.Options.UseForeColor = true;
            coltutar.Caption = "Tutar";
            coltutar.DisplayFormat.FormatString = "C2";
            coltutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            coltutar.FieldName = "Tutar";
            coltutar.MinWidth = 25;
            coltutar.Name = "coltutar";
            coltutar.OptionsColumn.AllowEdit = false;
            coltutar.OptionsColumn.ReadOnly = true;
            coltutar.Visible = true;
            coltutar.VisibleIndex = 4;
            coltutar.Width = 94;
            // 
            // Tarih
            // 
            Tarih.Caption = "Tarih";
            Tarih.FieldName = "Tarih";
            Tarih.MinWidth = 25;
            Tarih.Name = "Tarih";
            Tarih.Visible = true;
            Tarih.VisibleIndex = 5;
            Tarih.Width = 94;
            // 
            // UcStokCikis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "UcStokCikis";
            Size = new Size(1010, 509);
            ((System.ComponentModel.ISupportInitialize)lookUpEditUrun.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditMusteri.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEditBirimFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEditMiktar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditGirisTarihi.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditGirisTarihi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditUrun).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditTedarikci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUrun;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMusteri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditBirimFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinEditMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEditGirisTarihi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colTedarikci;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUrun;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTedarikci;
        private DevExpress.XtraGrid.Columns.GridColumn coltutar;
    }
}
