using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class siparisDetayRepo : IISlem<siparisDetay>
    {
        private ApplicationDbContext _context;
        public siparisDetayRepo(ApplicationDbContext Context)
        {
            _context = Context;
                
        }
        
        public void Delete(siparisDetay entity)
        {
            if(entity!= null)
            {
                _context.siparisDetays.Remove(entity);
                _context.SaveChanges();
            }
        }

        public siparisDetay Get(int id)
        {
            return _context.siparisDetays.Find(id);
        }
        public List<urun> cokSatan()
        {
            List<urun> Çsatan = new List<urun>();
             var query = _context.siparisDetays.OrderByDescending(s=> s.miktar).GroupBy(x => x.urunId).Select(x => new { quantity = x.Sum(b => b.miktar), Id = x.Key });
            var product = query.Take(10);
            foreach(var item in  product)
            {
                Çsatan.Add(_context.uruns.SingleOrDefault(x => x.urunId == item.Id));
            }
            return Çsatan;

        }

        public IEnumerable<siparisDetay> GetAll()
        {
            return _context.siparisDetays.ToList();
        }

        public void Save(siparisDetay entity)
        {
            if (entity != null)
            {
                _context.siparisDetays.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(siparisDetay entity)
        {
            siparisDetay old = Get(entity.siparisId);
            _context.Entry(old).State =EntityState.Detached;
            _context.Entry(entity).State =EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
