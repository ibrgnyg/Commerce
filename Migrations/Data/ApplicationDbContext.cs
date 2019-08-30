using System;
using System.Collections.Generic;
using System.Text;
using Commerce.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Commerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<urun> uruns { get; set; }
        public DbSet<resim> resims { get; set; }
        public DbSet<User> users  { get; set; }
        public DbSet<yorum> yorums   { get; set; }
        public DbSet<siparis> sipariss    { get; set; }
        public DbSet<siparisDetay> siparisDetays    { get; set; }
        public DbSet<indirim> indirims    { get; set; }
        public DbSet<favorim> favorims     { get; set; }
        
        public DbSet<kategori> kategoris  { get; set; }
        public DbSet<Basket> baskets  { get; set; }

       

    }
}
