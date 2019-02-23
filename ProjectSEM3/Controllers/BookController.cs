using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSEM3.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("ok");
            return View();
        }
    }
}