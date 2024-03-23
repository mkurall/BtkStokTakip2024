﻿using BtkProje.Servis;
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
    public partial class UcUrunler : UserControl
    {
        public UcUrunler()
        {
            InitializeComponent();

            repositoryItemLookUpEditBirimler.DataSource = DbServisi.BirimListesi();

            repositoryItemLookUpEditKategoriler.DataSource = DbServisi.KategoriListesi();

            VerileriYukle();
        }

        void VerileriYukle()
        {
            gridControl1.DataSource = DbServisi.UrunBagliListesi();
        }

    }
}
