using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblUrun:TemelModel
    {
        public int Id { get; set; }
        public string UrunKod { get; set; }
        public int KategoriId { get; set; }
        [MaxLength(50)]
        public string UrunAd { get; set; }
        public int BirimId { get; set; }
        [MaxLength(100)]
        public string? Aciklama { get; set; }
        public double? MinStok { get; set; }
        public double? MaksStok { get; set;}

        public TblKategori Kategori { get; set; }
        public TblBirim Birim { get; set; }

    }
}
