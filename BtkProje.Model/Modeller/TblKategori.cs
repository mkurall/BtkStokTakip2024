using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblKategori : TemelModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string KategoriAd { get; set; }

        public List<TblUrun> Urunler { get; set; } = new List<TblUrun>();
    }
}
