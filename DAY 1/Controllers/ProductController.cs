﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
