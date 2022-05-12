using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prog_web_tp_2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace prog_web_tp_2.Controllers
{
    public class GestionEnfantController : Controller
    {
        private readonly FausseBaseDeDonnees DB;

        public GestionEnfantController(FausseBaseDeDonnees DB)
        {
            this.DB = DB;
        }

        // GET: GestionEnfantController/Create
        public ActionResult Create()
        {
            ViewData["Parents"] = DB.Parents;
            return View();
        }

        // POST: GestionEnfantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enfant enfant)
        {

            ViewData["Parents"] = DB.Parents;

            if (!ModelState.IsValid)
                return View();

            try
            {
                enfant.Id = DB.Enfants.Max(e => e.Id) + 1;
                enfant.Parent = DB.Parents.Single(p => p.Id == enfant.IdParent);
                enfant.Parent.Enfants.Add(enfant);
                DB.Enfants.Add(enfant);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionEnfantController/Delete/5
        [Route("/GestionEnfant/Delete/{id}")]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Enfant e = DB.Enfants.SingleOrDefault(e => e.Id == id);

            return e != null ? View(e) : View("PageNotFound");

        }

        // POST: GestionEnfantController/Delete/5
        [ValidateAntiForgeryToken]
        [Route("/GestionEnfant/Delete/{id}")]
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {

            Enfant e = DB.Enfants.SingleOrDefault(e => e.Id == id);
            e.Parent.Enfants.Remove(e);
            DB.Enfants.Remove(e);
            return RedirectToAction("Index", "Home");
        }
    }
}
