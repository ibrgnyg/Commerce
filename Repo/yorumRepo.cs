using Commerce.Areas.Admin.Models;
using Commerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class yorumRepo
    {
        private ApplicationDbContext _context;
        public yorumRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }

        public string yorumSave( yorum yorum)
        {
            if(yorum!= null)
            {
                _context.yorums.Add(yorum);
                _context.SaveChanges();

                return "yorum yapıldı";
            }
            else
            return "yorum yaparken hata oluştu";

        }
    }
}
