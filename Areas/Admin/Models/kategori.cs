using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class kategori
    {
        public int kategoriId { get; set; }
        public string kategoriName { get; set; }

        public virtual ICollection<urun> Uruns { get; set; }
      
    }
}
