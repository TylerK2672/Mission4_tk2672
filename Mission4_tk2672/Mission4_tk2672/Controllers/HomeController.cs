using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission4_tk2672.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission4_tk2672.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index ()
        {
            return View();
        }

        [HttpGet]

        public IActionResult GradeCalculator ()
        {
            return View();
        }

        [HttpPost]

        public IActionResult GradeCalculator (GradeCalculatorModel model)
        {
            return View();
        }
    }
}