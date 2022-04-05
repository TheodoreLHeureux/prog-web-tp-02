using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_web_tp_2.Models
{
    public class Enfant
    {

        public int Id { get; set; }
        public int IdParent { get; set; }
        public Parent Parent { get; set; }
        public string ImageURL { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Chipset { get; set; }
        public int Memory { get; set; }
        public string MemType { get; set; }
        public int BoostClock { get; set; }
        public int CoreClock { get; set; }
        public int Length { get; set; }
        public int TDP { get; set; }
        public int HDMIPorts { get; set; }
        public int DPPorts { get; set; }
        public string MaximumRes { get; set; }
        public float Prix { get; set; }

    }
}
