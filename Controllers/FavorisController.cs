using System.Collections.Generic;
using System.Linq;
using prog_web_tp_2.Models;
using prog_web_tp_2.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace prog_web_tp_2.Controllers
{
    public class FavorisController : Controller
    {
        private readonly FausseBaseDeDonnees DB;

        public FavorisController(FausseBaseDeDonnees DB)
        {
            this.DB = DB;
        }

        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs") ?? new List<int>();

            var enfantsDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();

            return View(enfantsDeLaBD);
        }

        [HttpPost]
        public IActionResult AjouterUnEnfant(int id)
        {
            var favorisId = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (favorisId == null) 
                favorisId = new List<int>();

            if (!favorisId.Contains(id))
                favorisId.Add(id);


            HttpContext.Session.Set<List<int>>("enfantsIDs", favorisId);

            var enfantsDeLaBD = DB.Enfants.Where(e => favorisId.Contains(e.Id)).ToList();

            return View("Index", enfantsDeLaBD);
        }

        [HttpPost]
        public IActionResult SupprimerUnEnfant(int id)
        {
            List<int> favorisId = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (favorisId == null)
                favorisId = new List<int>();

            if (favorisId.Contains(id))
                favorisId.Remove(id);


            HttpContext.Session.Set<List<int>>("enfantsIDs", favorisId);

            var enfantsDeLaBD = DB.Enfants.Where(e => favorisId.Contains(e.Id)).ToList();
            return View("Index", enfantsDeLaBD);
        }
    }
}
