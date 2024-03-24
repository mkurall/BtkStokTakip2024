using BtkProje.Servis;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkProje.App
{
    public partial class frmGiris : XtraForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;
            btnGiris.Enabled = false;
            txtKullaniciAd.Enabled = false;
            txtParola.Enabled = false;

            await Task.Run(() =>
            {

                string sifreliParola = ByteArrayToString(MD5.HashData(Encoding.UTF8.GetBytes(txtParola.Text)));


                bool basariliMi = DbServisi.OturumAc(txtKullaniciAd.Text, sifreliParola);

                Invoke(new Action(()=> {

                        if (basariliMi) //Dialog Penceresini Başarılı dönerek kapatır
                            DialogResult = DialogResult.OK;
                        else
                        {

                            lblBilgi.Text = "Kullanıcı adı yada parola hatalı!";
                            lblBilgi.Visible = true;
                        }
                    }));
            });


            txtParola.Enabled = true;
            txtKullaniciAd.Enabled = true;
            btnGiris.Enabled = true;
            progressPanel1.Visible = false;
        }
    }
}
