using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class indirimRepo : IISlem<indirim>
    {
        private ApplicationDbContext _context;
        public indirimRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public void Delete(indirim entity)
        {
           if(entity!= null)
            {
                _context.indirims.Remove(entity);
                _context.SaveChanges();
            }
        }

        public indirim Get(int id)
        {
            return _context.indirims.Find(id);
        }

        public IEnumerable<indirim> GetAll()
        {
            return _context.indirims.ToList();
        }

        public void Save(indirim entity)
        {
            if (entity != null)
            {
                _context.indirims.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(indirim entity)
        {
            indirim old = Get(entity.indirimId);
            _context.Entry(old).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
