using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public partial class indirim
    {
        public int indirimId { get; set; }
        public string indirimKodu { get; set; }
        public string aciklama { get; set; }
        public decimal indirimTutar { get; set; }
        public DateTime indirimBaslangic { get; set; }
        public DateTime indirimBitis { get; set; }
        public bool indirimDurum { get; set; }
        public int musteriNo { get; set; }
        public bool kullanıldiMi { get; set; }

        public virtual User user { get; set; }
    }
}
