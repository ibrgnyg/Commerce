using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Commerce.Repo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using IFormFile = Microsoft.AspNetCore.Http.IFormFile;

namespace Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class urunController : Controller
    {
        private IHostingEnvironment _environment;
        private ApplicationDbContext _context;
        private urunRepo urunRepo;
        public urunController(ApplicationDbContext context,urunRepo urunRepo,IHostingEnvironment environment )
        {
            _context = context;
            _environment = environment;
            this.urunRepo = urunRepo;
            
           
           
        ;
        }
       
        public IActionResult Index()
        {
            //var uruns = urunRepo.GetAll();
            return View(urunRepo.GetAll());
        }
       public IActionResult Create()
       {
            ViewBag.kategoriler = urunRepo.KategoriListes();
            return View();
       }

        
        [HttpPost]
        public IActionResult Create(urun urun, IFormFile photo)
        {
            urun.eklemetarihi = DateTime.Now;
            if(photo!= null)
            {
                var path = Path.Combine(_environment.WebRootPath, "images", photo.FileName);
                var stream = new FileStream(path, FileMode.Create);
                photo.CopyTo(stream);
                resim pht = new resim()
                {
                    resimAdi = photo.FileName,
                    urunId = urun.urunId
                };
                //urunRepo.saveImage(pht);
                urun.Resimyolu = photo.FileName;
                ViewBag.photo = photo.FileName;
            }
           

            urunRepo.Save(urun);
            return RedirectToAction("Index","urun");
        }

     



        public IActionResult Delete(int  id)
        {
            return View(urunRepo.Get(id));
        }
        [HttpPost]
        public IActionResult delete(int id)
        {
            urunRepo.Delete(urunRepo.Get(id));
           return RedirectToAction("Index");
        }

        public IActionResult Edit (int id)
        {
            return View(urunRepo.Get(id));
        }
        [HttpPost]
        public IActionResult edit(urun urun)
        {
            urunRepo.Update(urun);
            return RedirectToAction("Index");
        }
    }
}