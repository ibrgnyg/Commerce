using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class favorimRepo : IISlem<favorim>
    {
        private ApplicationDbContext _context;
        public favorimRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public void Delete(favorim entity)
        {
           if(entity != null)
           {
                _context.favorims.Remove(entity);
                _context.SaveChanges();
           }
        }

        public favorim Get(int id)
        {
            return _context.favorims.Find(id);
        }

        public IEnumerable<favorim> GetAll()
        {
            return _context.favorims.ToList();
        }

        public void Save(favorim entity)
        {
            if (entity != null)
            {
                _context.favorims.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(favorim entity)
        {
            favorim old = Get(entity.id);
            _context.Entry(old).State =EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
