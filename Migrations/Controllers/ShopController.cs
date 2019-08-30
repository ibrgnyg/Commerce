using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Areas.Admin.Models;
using Commerce.Data;
using Commerce.Models;
using Commerce.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList;
using System.Net.Http;


namespace Commerce.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext _context;
        private urunRepo urunRepo;
        private siparisDetayRepo siparisDetayRepo;
        private yorumRepo yorumRepo;
        public ShopController(ApplicationDbContext Context,  urunRepo urunRepo,siparisDetayRepo siparisDetayRepo,yorumRepo yorumRepo)
        {
            _context = Context;
            this.urunRepo = urunRepo;
            this.siparisDetayRepo = siparisDetayRepo;
            this.yorumRepo = yorumRepo;

        }

        public PartialViewResult NewProduct()
        {
            return PartialView(urunRepo.GetAll().OrderByDescending(p => p.eklemetarihi).Take(5).ToList());
        }

        public PartialViewResult Çoksatan()
        {
            return PartialView(siparisDetayRepo.cokSatan());
        }

        public IActionResult Index(int? categoryId, string serach, int ? page , int? pageSize, int? orderBy ,int?miniPrice,int ?maxPrice)
        {
           ViewBag.orderBy = new List<SelectListItem>()
            {
                new  SelectListItem{ Text = "price" , Value="1" , Selected= true},
                new SelectListItem{Text="Name",Value="2"},
                new SelectListItem{Text="Id", Value="3" },
            };
            ViewBag.pageSize = new List<SelectListItem>()
            {
                new SelectListItem { Text = "20", Value = "20", Selected = true },
                new SelectListItem { Text = "10", Value = "10" },
                new SelectListItem { Text = "5", Value = "5" },

            };

            int pageNumber = page ?? 1;

            int PageSize = pageSize ?? 7;

            var result = urunRepo.GetAll();
            if (categoryId != null)
            {
                result = result.Where(c => c.urunId == categoryId).ToList();
            }
            else if (orderBy == 1)
                result = result.OrderBy(f => f.Price).ToList();

            else if (orderBy == 2)
                result = result.OrderBy(n => n.urunName).ToList();

            else if (orderBy == 3)
                result = result.OrderBy(ı => ı.urunId).ToList();

            else if (miniPrice != null & miniPrice != null)
                result = result.Where(x => x.Price >= miniPrice && x.Price <= maxPrice).ToList();

            else if (serach != null)
                result = result.Where(k => k.Kategori.kategoriName.Contains(serach) || k.urunName.Contains(serach)).ToList();

            //var uruns = urunRepo.GetAll();

            return View(result.ToPagedList(pageNumber,PageSize));
        }

        //
        public IActionResult productDetail(int productId)
        {
            var uruns = urunRepo.Get(productId);
            return View(uruns);
        }//

        //
        public IActionResult partialPrice()
        {
            return PartialView();
        }

        
        public IActionResult PartialCategory()
        {
            
            return PartialView(urunRepo.KategoriListes());
        }
       
        public string yorumsave(int _urunId,string _yorumcu,string _yorum)
        {
            yorum model = new yorum()
            {

                yorumcu = _yorumcu,
                yorumAdi = _yorum,
                yorumTarihi = DateTime.Now,
                urunId = _urunId,
                
            };
            return yorumRepo.yorumSave(model);
        }
        
        public string  createCuppon()
        {
            Random R = new Random();
            string result = "";
            char[] expression = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'V', 'Y', 'X', 'W', 'Z', '1', '2', '3', '4', '5' };
            for (int i = 0;i < 8;i++)
            {
                result += expression[R.Next(expression.Length)].ToString();

            }
            return result;
        }
        
        public IActionResult Basket()
        {
            return View();
        }
        

        /*[HttpPost]
        public  void ClearCard()
        {
            Session["card"] = null;
        }

       



        public void deleteCard(int productId)
        {
            List<Basket> card = (List<Basket>)HttpContext.Session["card"];
            if (card.Exists(x => x.product.urunId == productId))
            {
                int index = isExistInCard(productId);
                card.RemoveAt(index);
                HttpContext.Session["card"] = card;
            }
        }

        [HttpPost]
        public void UpdateCard(int productId,int qantity)
        {
            if(Session["card"]= null)
            {
                List<Basket> car = (List<Basket>)Session["card"];
                int index = isExistInCard(productId);
                if(index!= -1)
                {
                    card[index].qantity = qantity;
                }
            }
        }

        [NonAction]
        public bool isExitCart(int id)
        {
            List<Basket> card = (List<Basket>)Session["card"];
            for (int i = 0; i < card.Count; i++)
                if (card[i].product.urunId.Equals(id))
                    return i;
            return -1;
        }

        public IActionResult AddCar(int productId, int qantityId)
        {
            urun _product = urunRepo.Get(productId);

            if(Session["Card"]== null)
            {
                List<Basket> Card = new List<Basket>();
                Card.Add(new Basket()
                {
                    Id = Guid.NewGuid(),
                    product= _product,
                    quantity = qantity,
                    DateCreated= DateTime.Now
                });
                Session["Card"] = Card;
            }

            else
            {
                List<Basket> card = (List<Basket>)Session["Card"];
                int index = isExitcart(productId);
                if(index!=-1)
                {
                    card[index].quantity += quantity;
                }

                else
                    card.Add(new Basket
                    {  Id =Guid.NewGuid(),
                        product= _product,
                        quantity =qantity,
                        DateCreated= DateTime.Now,


                    });
                Session["Card"] = card;
            }
            return RedirectToAction("Index");
           
        }*/
    }
}