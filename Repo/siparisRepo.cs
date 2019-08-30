using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class siparisRepo : IISlem<siparis>
    {
        private ApplicationDbContext _context;
        public siparisRepo(ApplicationDbContext  Context)
        {
            _context = Context;
        }

        public void Delete(siparis entity)
        {
            if(entity!= null)
            {
                _context.sipariss.Remove(entity);
                _context.SaveChanges();
            }
        }

        public siparis Get(int id)
        {
            return _context.sipariss.Find(id);
        }

        public IEnumerable<siparis> GetAll()
        {
            return _context.sipariss.ToList();
        }

        public void Save(siparis entity)
        {
            if (entity != null)
            {
                _context.sipariss.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(siparis entity)
        {
            siparis old = Get(entity.siparisId);
            _context.Entry(old).State =EntityState.Detached;
            _context.Entry(entity).State =EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
