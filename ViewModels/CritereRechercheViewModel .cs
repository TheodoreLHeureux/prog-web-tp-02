using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_web_tp_2.Models
{
    public class CritereRechercheViewModel
    {
        public string? MotsCles { get; set; }
        public bool Asus { get; set; }
        public bool Gigabyte { get; set; }
        public bool EVGA { get; set; }
        public bool Est3060 { get; set; }
        public bool Est3070 { get; set; }
        public bool Est3080 { get; set; }
        public bool Est3090 { get; set; }
        public int? PrixMin { get; set; }
        public int? PrixMax { get; set; }
        public int ArticlePremium { get; set; }
    }
}
