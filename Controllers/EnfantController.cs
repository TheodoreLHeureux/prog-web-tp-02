using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            var model = new PageRechercheViewModel();
            model.Criteres.Est3060 = true;
            model.Criteres.Est3070 = true;
            model.Criteres.Est3080 = true;
            model.Criteres.Est3090 = true;
            model.Criteres.Asus = true;
            model.Criteres.Gigabyte = true;
            model.Criteres.EVGA = true;
            model.Resultat = DB.Enfants;
            return View(model);
        }
        

        [Route("/filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {

            IEnumerable<Enfant> donnees = DB.Enfants;

            if (criteres.MotsCles != null)
                donnees = donnees.Where(e => e.Nom.ToLower().Contains(criteres.MotsCles.ToLower()));

            if (!criteres.Asus)
                donnees = donnees.Where(e => e.IdParent != 0);
            if (!criteres.Gigabyte)
                donnees = donnees.Where(e => e.IdParent != 1);
            if (!criteres.EVGA)
                donnees = donnees.Where(e => e.IdParent != 2);

            if (!criteres.Est3060)
                donnees = donnees.Where(e => e.Chipset != enuChipsets.GeForce_RTX_3060);
            if (!criteres.Est3070)
                donnees = donnees.Where(e => e.Chipset != enuChipsets.GeForce_RTX_3070);
            if (!criteres.Est3080)
                donnees = donnees.Where(e => e.Chipset != enuChipsets.GeForce_RTX_3080);
            if (!criteres.Est3090)
                donnees = donnees.Where(e => e.Chipset != enuChipsets.GeForce_RTX_3090);

            if (criteres.PrixMax != null)
                donnees = donnees.Where(e => e.Prix <= criteres.PrixMax);
            if (criteres.PrixMin != null)
                donnees = donnees.Where(e => e.Prix >= criteres.PrixMin);

            switch (criteres.ArticlePremium)
            {
                case 1:
                    donnees = donnees.Where(e => e.Premium);
                    break;
                case 2:
                    donnees = donnees.Where(e => !e.Premium);
                    break;
            }


            return View("Recherche", new PageRechercheViewModel(criteres, donnees.ToList()));
        }

        public IActionResult Detail()
        {
            return View();
        }

        [Route("/enfant/detail/{id:int}")]
        [Route("/enfant/{id:int}")]
        [Route("/{id:int}")]
        [Route("/detail/{id:int}")]
        public IActionResult DetailParId(int Id)
        {
            Enfant e = DB.Enfants.SingleOrDefault(E => E.Id == Id);

            if (e != null)
                return View("Detail", e);

            return View("PageNotFound");
        }

        [Route("/enfant/detail/{nom}")]
        [Route("/enfant/{nom}")]
        [Route("/{nom}")]
        [Route("/detail/{nom}")]
        public IActionResult DetailParNom(string nom)
        {
            Enfant e = DB.Enfants.SingleOrDefault(E => E.Nom.Replace(' ', '_').ToLower() == nom);

            if (e != null)
                return View("Detail", e);

            return View("PageNotFound");

        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
