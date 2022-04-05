using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_web_tp_2.Controllers
{
    public class EnfantController : Controller
    {
        public IActionResult Recherche()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
