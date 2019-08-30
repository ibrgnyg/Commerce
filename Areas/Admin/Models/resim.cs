using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class resim
    {
        public int resimId{ get; set; }
        
        public string resimAdi { get; set; }

        public int urunId { get; set; }

        public virtual urun urun { get; set; }
    }
}
