using Commerce.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public urun product { get; set; }
        public int quantity { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
