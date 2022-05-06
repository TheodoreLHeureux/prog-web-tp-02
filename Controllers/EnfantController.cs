using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using prog_web_tp_2.Models;

namespace prog_web_tp_2.Controllers
{
    public class EnfantController : Controller
    {
        private readonly FausseBaseDeDonnees DB;

        public EnfantController(FausseBaseDeDonnees DB)
        {
            this.DB = DB;
        }
        
        [Route("/recherche")]
        [Route("enfant/recherche")]
        public IActionResult Recherche()
        {
            return View(DB);
        }


        [Route("/enfant/detail/{id:int}")]
        [Route("/enfant/{id:int}")]
        [Route("/{id:int}")]
        [Route("/detail/{id:int}")]
        public IActionResult DetailParId(int Id)
        {
            try
            {
                return View(DB.Enfants.Single(E => E.Id == Id));
            }
            catch
            {
                return Redirect("/enfant/pagenotfound");
            }
        }

        [Route("/enfant/detail/{nom}")]
        [Route("/enfant/{nom}")]
        [Route("/{nom}")]
        [Route("/detail/{nom}")]
        public IActionResult DetailParNom(string nom)
        {
            try
            {
                return View(DB.Enfants.Single(E => E.Nom.Replace(' ', '_').ToLower() == nom)));
            }
            catch
            {
                return Redirect("/enfant/pagenotfound");
            }

        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
