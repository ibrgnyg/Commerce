using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public class userRepo : IISlem<User>
    {
        private ApplicationDbContext _context;
        public userRepo(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public void Delete(User entity)
        {
           if(entity!= null)
            {
                _context.users.Remove(entity);
                _context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            return _context.users.FirstOrDefault(x => x.userId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.users.ToList();
        }

        public void Save(User entity)
        {
            if (entity != null)
            {
                _context.users.Add(entity);
                _context.SaveChanges();
            }
        }
        public List<urun> Listess()
        {
            return _context.uruns.ToList();
        }

        public void Update(User entity)
        {
            User old = Get(entity.userId);
            _context.Entry(old).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
