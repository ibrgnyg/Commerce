using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Commerce.Models.Security;
using Commerce.Repo;
using Commerce.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    public class userController : Controller
    {
        private ApplicationDbContext _context;
        private userRepo userRepo;
        private readonly SignInManager<IdentityUser> signInManager;

        public userController(ApplicationDbContext Context, userRepo userRepo, SignInManager<IdentityUser> signInManager)
        {
            _context = Context;
            this.userRepo = userRepo;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(User user)
        {
            var lgn = await signInManager.PasswordSignInAsync(user.firstname, user.password, false, true);
            if(lgn.Succeeded)
            {
                TempData["Mesaj"] = "oturum Açma İşlemi başarılı";
                return RedirectToAction("Index", "Home");
            }

            else
            {
                TempData["Mesaj"] = "kullanıcı adı veya Şifre Hatalı..";
                return View();
            }
        }

      
        /*public IActionResult Index()
        {
            return View();
        }
        [NonAction]
        public bool ısExitUser(string userName)
        {
            var result = userRepo.GetAll().Where(u => u.email == userName).FirstOrDefault();
            return result == null ? false : true;
        }

        [HttpGet]
        public IActionResult VerifyCode(string id)
        {
            bool status = false;
            var result = userRepo.GetAll().Where(a => a.activationCode == new Guid(id).ToString()).FirstOrDefault();
            if (result!= null)
            {
                result.isMailVerified = true;
                userRepo.Update(result);
                status = true;
            }

            else
            {
                ViewBag.Message = "geçersiz istek";
            }
            ViewBag.status = status;
            return View("Index");
        }

        [HttpGet]
        public IActionResult Register(User user)
        {
            string messge = "";
            bool status = false;

            if(ısExitUser(user.email))
            {
                messge = "Boyle Bir Kullanıcı Mevcut";
                ViewBag.status = status;
                ViewBag.message = messge;
                return View("Index");

            }
            user.activationCode = Guid.NewGuid().ToString();
            user.password = Crypto.Hash(user.password);
            user.rePassword = Crypto.Hash(user.rePassword);
            user.isMailVerified = false;
            user.createdDate = DateTime.Now;
            userRepo.Save(user);


            return View();

        }


        public IActionResult Login()
        {
            return View();
        }

       /* public IActionResult Login(Login login, string ReturnUrl)
        {
            string message = "";
            bool status = false;
            int count = 0;

            var result = userRepo.GetAll().Where(a => a.email == login.email).FirstOrDefault();
            bool verified = user.isMailVerified ?? false;

            if(! verified)
            {
                ViewBag.message = "Doğrulama Kodu için Maile Adresinize bakınız";
                count++;
                user.loginAttempt = count;
                userRepo.Update(user);
                return View();
            }

            login.password = Crypto.Hash(login.password);

        }*/

    }
}