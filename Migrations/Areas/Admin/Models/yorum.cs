using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class yorum
    {
        public int yorumId { get; set; }
        public int urunId { get; set; }
        public string yorumAdi { get; set; }
        public string yorumcu { get; set; }
        public DateTime yorumTarihi { get; set; }

        public virtual urun urun { get; set; }
    }
}
