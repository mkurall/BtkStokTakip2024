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
            ((System.ComponentModel.ISupportInitialize)txtKategoriAd.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(21, 35);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(69, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kategori Adı";
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(108, 32);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(281, 22);
            txtKategoriAd.TabIndex = 1;
            // 
            // UcKategoriDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtKategoriAd);
            Controls.Add(labelControl1);
            Name = "UcKategoriDetay";
            Size = new Size(429, 617);
            ((System.ComponentModel.ISupportInitialize)txtKategoriAd.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAd;
    }
}
