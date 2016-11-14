using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lib;
using Microsoft.AspNetCore.Mvc;

namespace msbuild_failure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = Class1.SayHello();
            return View();
        }
    }
}
