using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prog_web_tp_2.Models;

namespace prog_web_tp_2.Controllers
{
    public class HomeController : Controller
    {

        private FausseBaseDeDonnees BD;

        public HomeController(FausseBaseDeDonnees BD)
        {
            this.BD = BD;
        }

        public IActionResult Index()
        {
            return View(BD.Parents);
        }
    }

}
