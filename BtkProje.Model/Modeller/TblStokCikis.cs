using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblStokCikis : TemelModel
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public double BirimFiyat { get; set; }
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; }

        public TblMusteri Musteri { get; set; }
        public TblUrun Urun { get; set; }

        [NotMapped]
        public double Tutar { get { return BirimFiyat * Miktar; } }
    }
}
