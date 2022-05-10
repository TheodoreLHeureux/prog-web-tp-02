using System.Collections.Generic;

namespace prog_web_tp_2.Models
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }
        public List<Enfant> Resultat { get; set; }

        public PageRechercheViewModel()
        {
            Criteres = new CritereRechercheViewModel();
            Resultat = new List<Enfant>();
        }

        public PageRechercheViewModel(CritereRechercheViewModel criteres, List<Enfant> resultat)
        {
            Criteres = criteres;
            Resultat = resultat;
        }

    }
}