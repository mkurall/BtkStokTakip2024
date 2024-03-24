namespace BtkProje.App
{
    partial class frmGiris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtParola = new DevExpress.XtraEditors.TextEdit();
            btnGiris = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblBilgi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(80, 127);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(87, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.EditValue = "admin";
            txtKullaniciAd.Location = new Point(210, 120);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            txtKullaniciAd.Size = new Size(193, 26);
            txtKullaniciAd.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(80, 163);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(44, 19);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.EditValue = "1234";
            txtParola.Location = new Point(210, 156);
            txtParola.Name = "txtParola";
            txtParola.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtParola.Properties.Appearance.Options.UseFont = true;
            txtParola.Properties.Name = "txtParola";
            txtParola.Properties.PasswordChar = '●';
            txtParola.Size = new Size(193, 26);
            txtParola.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Appearance.Options.UseFont = true;
            btnGiris.Location = new Point(280, 200);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(123, 48);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.Click += btnGiris_Click;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(progressPanel1);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(pictureBox1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(426, 96);
            panelControl1.TabIndex = 3;
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = Color.Transparent;
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.Caption = "Oturum Açılıyor";
            progressPanel1.Description = "";
            progressPanel1.Location = new Point(104, 59);
            progressPanel1.LookAndFeel.SkinName = "DevExpress Style";
            progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            progressPanel1.Name = "progressPanel1";
            progressPanel1.ShowDescription = false;
            progressPanel1.Size = new Size(266, 25);
            progressPanel1.TabIndex = 8;
            progressPanel1.Visible = false;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(103, 24);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(286, 29);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Btk Proje - Güvenli Giriş";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.security;
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(15, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(15, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblBilgi
            // 
            lblBilgi.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBilgi.Appearance.ForeColor = Color.Red;
            lblBilgi.Appearance.Options.UseFont = true;
            lblBilgi.Appearance.Options.UseForeColor = true;
            lblBilgi.Location = new Point(18, 215);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(30, 19);
            lblBilgi.TabIndex = 7;
            lblBilgi.Text = "Bilgi";
            lblBilgi.Visible = false;
            // 
            // frmGiris
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(426, 274);
            Controls.Add(lblBilgi);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panelControl1);
            Controls.Add(btnGiris);
            Controls.Add(txtParola);
            Controls.Add(labelControl2);
            Controls.Add(txtKullaniciAd);
            Controls.Add(labelControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oturum Açın";
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl lblBilgi;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}