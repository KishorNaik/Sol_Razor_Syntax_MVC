using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Razor_Syntax.Controllers
{
    public class RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}