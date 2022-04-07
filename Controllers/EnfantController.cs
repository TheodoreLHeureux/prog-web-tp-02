using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using prog_web_tp_2.Models;

namespace prog_web_tp_2.Controllers
{
    public class EnfantController : Controller
    {
        private FausseBaseDeDonnees DB;

        public EnfantController(FausseBaseDeDonnees DB)
        {
            this.DB = DB;
        }

        public IActionResult Recherche()
        {
            return View(DB);
        }

        public IActionResult Detail(int Id)
        {
            foreach (Enfant e in DB.Enfants)
                if (e.Id == Id)
                    return View(e);

            return View("PageNotFound");
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
