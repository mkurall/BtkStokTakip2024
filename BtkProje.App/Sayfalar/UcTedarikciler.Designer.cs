namespace BtkProje.App.Sayfalar
{
    partial class UcTedarikciler
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
            colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            colYetkiliAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Left;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1009, 457);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colFirma, colYetkiliAdSoyad, colTel, colMail, colAdres });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colFirma
            // 
            colFirma.Caption = "Firma";
            colFirma.FieldName = "FirmaAd";
            colFirma.MinWidth = 25;
            colFirma.Name = "colFirma";
            colFirma.Visible = true;
            colFirma.VisibleIndex = 0;
            colFirma.Width = 195;
            // 
            // colYetkiliAdSoyad
            // 
            colYetkiliAdSoyad.Caption = "Firma Yetkilisi";
            colYetkiliAdSoyad.FieldName = "YetkiliAdSoyad";
            colYetkiliAdSoyad.MinWidth = 25;
            colYetkiliAdSoyad.Name = "colYetkiliAdSoyad";
            colYetkiliAdSoyad.Visible = true;
            colYetkiliAdSoyad.VisibleIndex = 1;
            colYetkiliAdSoyad.Width = 195;
            // 
            // colTel
            // 
            colTel.Caption = "Telefon";
            colTel.FieldName = "Tel";
            colTel.MinWidth = 25;
            colTel.Name = "colTel";
            colTel.Visible = true;
            colTel.VisibleIndex = 2;
            colTel.Width = 100;
            // 
            // colMail
            // 
            colMail.Caption = "Mail";
            colMail.FieldName = "Mail";
            colMail.MinWidth = 25;
            colMail.Name = "colMail";
            colMail.Visible = true;
            colMail.VisibleIndex = 3;
            colMail.Width = 113;
            // 
            // colAdres
            // 
            colAdres.Caption = "Adres";
            colAdres.FieldName = "Adres";
            colAdres.MinWidth = 25;
            colAdres.Name = "colAdres";
            colAdres.Visible = true;
            colAdres.VisibleIndex = 4;
            colAdres.Width = 449;
            // 
            // UcTedarikciler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Name = "UcTedarikciler";
            Size = new Size(1100, 457);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
    }
}
