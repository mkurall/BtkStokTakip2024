using BtkProje.Servis;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;

            await Task.Run(() =>
            {
                bool basariliMi = DbServisi.OturumAc(txtKullaniciAd.Text, txtParola.Text);

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

            progressPanel1.Visible = false;
        }
    }
}
