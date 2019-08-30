using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public  class urunRepo :IISlem<urun> 
    {
        private ApplicationDbContext _context;
        public urunRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }

        public void saveImage(resim resim)
        {
            if(resim!= null)
            {
                _context.resims.Add(resim);
                _context.SaveChanges();
            }
        }

        public void Delete(urun entity)
        {
          if(entity!= null)
          {
                _context.uruns.Remove(entity);
                _context.SaveChanges();
          }
        }

        public urun Get(int id)
        {
            return _context.uruns.Find(id);
        }

        public IEnumerable<kategori> KategoriListes()
        {
            return _context.kategoris.ToList();
        }

        public IEnumerable<urun> GetAll()
        {
            return _context.uruns.ToList();
        }
        public void resimInsert(resim entity)
        {
            if(entity!= null)
            {
                _context.resims.Add(entity);
                _context.SaveChanges();
            }
        }
        public void Save(urun entity)
        {
            if (entity != null)
            {
                _context.uruns.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(urun entity)
        {
             urun eski = Get(entity.urunId);
            _context.Entry(eski).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

    
}
