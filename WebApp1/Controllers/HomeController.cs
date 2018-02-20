using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebAPI;
using WebAPI.Controllers;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ValuesController vc = new ValuesController();
            IEnumerable<string> values = vc.Get();
            string v1 = values.First();

            ViewData["Message"] = v1;

            return View();
        }

        public IActionResult Contact()
        {
            ValuesController vc = new ValuesController();
            IEnumerable<string> values = vc.Get();
            string v2 = values.ElementAt(1);

            ViewData["Message"] = v2;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyNewMethod()
        {
            throw new NotImplementedException();
        }
    }
}
