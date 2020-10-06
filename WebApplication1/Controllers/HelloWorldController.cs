using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThisIsMe()
        {
            ViewBag.Now = DateTime.Now;
            ViewBag.Name = "Derek Bacy";
            ViewBag.Hobby = "Programming";
            return View();
        }
    }
    
}