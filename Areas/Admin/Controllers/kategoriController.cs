using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Commerce.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class kategoriController : Controller
    {
        private readonly ApplicationDbContext _context;
        private kategoriRepo kategoriRepo;
        public kategoriController(ApplicationDbContext context , kategoriRepo kategoriRepo)
        {
            _context = context;
           this.kategoriRepo = kategoriRepo;
        }

        public IActionResult Index()
        {
            return View(kategoriRepo.GetAll());
        }
        public IActionResult  Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(kategori kategori)
        {
            kategoriRepo.Save(kategori);
            return RedirectToAction("Index");
        }
       
        public IActionResult Delete(int id)
        {
            return View(kategoriRepo.Get(id));
        }
        [HttpPost]
        public IActionResult delete(int id)
        {
            kategoriRepo.Delete(kategoriRepo.Get(id));
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(kategoriRepo.Get(id));
        }
        [HttpPost]
        public IActionResult edit(kategori kategori)
        {
            kategoriRepo.Update(kategori);
            return RedirectToAction("Index");
        }

    }
}