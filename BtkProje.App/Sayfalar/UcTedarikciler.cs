using BtkProje.Servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkProje.App.Sayfalar
{
    public partial class UcTedarikciler : UserControl
    {
        public UcTedarikciler()
        {
            InitializeComponent();

            VerileriYukle();
        }

        void VerileriYukle()
        {
            var liste = DbServisi.TedarikciBagliListesi();

            gridControl1.DataSource = liste;
        }
    }
}
