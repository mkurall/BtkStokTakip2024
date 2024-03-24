using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.Model.Modeller
{
    public class TblBirim:TemelModel
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string BirimAd { get; set; }

       
    }
}
