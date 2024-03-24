using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblTedarikci : TemelModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirmaAd { get; set; }
        [MaxLength(50)]
        public string? YetkiliAdSoyad { get; set; }
        [MaxLength(15)]
        public string? Tel { get; set; }
        [MaxLength(50)]
        public string? Mail { get; set; }
        [MaxLength(100)]
        public string? Adres { get; set; }

        public List<TblStokGiris> StokGirisler { get; set; } = new List<TblStokGiris>();
    
        public string Bilgi
        {
            get
            {
                return FirmaAd+"("+YetkiliAdSoyad+")";
            }
        }
    }
}
