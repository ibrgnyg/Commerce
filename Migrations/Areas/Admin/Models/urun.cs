using Commerce.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Areas.Admin.Models
{
    public class urun
    {
        public int  urunId { get; set; }
        public string  urunName { get; set; }
        public string urunAçıklama{ get; set; }
        public decimal Price { get; set; }
        public string Resimyolu { get; set; }
        public DateTime eklemetarihi { get; set; }
        public  int stock{ get; set; }

        [NotMapped]
        public IFormFile ResimDosyası { get; set; }
        public int kategoriId { get; set; }
        public virtual kategori Kategori { get; set; }
        public virtual ICollection<resim> resims { get; set; }
        public virtual ICollection<yorum> yorum  { get; set; }
    }
}
