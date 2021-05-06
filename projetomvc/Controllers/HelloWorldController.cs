using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace projetomvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numtimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numtimes;

            return View();
        }
    }
}