﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

   

       
    }
}