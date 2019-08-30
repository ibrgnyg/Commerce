using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public partial class favorim
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int userId { get; set; }

        public virtual urun urun { get; set; }
        public virtual User user { get; set; }
    }
}
