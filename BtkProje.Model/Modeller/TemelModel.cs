using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TemelModel
    {
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? GuncelleyenKullaniciId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        [ForeignKey("OlusturanKullaniciId")]
        public TblKullanici? OlusturanKullanici { get; set; }
        [ForeignKey("GuncelleyenKullaniciId")]
        public TblKullanici? GuncelleyenKullanici {  set; get; }
    }
}
