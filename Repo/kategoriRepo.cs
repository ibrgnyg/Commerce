using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class kategoriRepo : IISlem<kategori>
    {
        private ApplicationDbContext _context;
        public kategoriRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }

        public void Delete(kategori entity)
        {
            if(entity!= null)
            {
                _context.kategoris.Remove(entity);
                _context.SaveChanges();
            }
        }

        public kategori Get(int id)
        {
            return _context.kategoris.Find(id);
        }

        public IEnumerable<kategori> GetAll()
        {
            return _context.kategoris.ToList();
        }

        public void Save(kategori entity)
        {
           if(entity!= null)
           {
                _context.kategoris.Add(entity);
                _context.SaveChanges();
           }
        }

        public void Update(kategori entity)
        {
             kategori eski = Get(entity.kategoriId);
            _context.Entry(eski).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
