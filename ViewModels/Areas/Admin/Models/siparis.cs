using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class siparis
    {
        public int siparisId { get; set; }
        public int musteriId { get; set; }
        public DateTime siparisTarihi { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string company { get; set; }
        public string city { get; set; }
        public int postakodu { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public decimal gonderimtutar { get; set; }
        public bool farkliadres { get; set; }
        public decimal indirimtutar { get; set; }
        public decimal siparistutar { get; set; }

        public virtual User user { get; set; }
        
        public virtual ICollection<siparisDetay> siparisDetay { get; set; }
    }
}
