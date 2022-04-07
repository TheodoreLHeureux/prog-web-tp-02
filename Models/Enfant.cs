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
        public enuChipsets Chipset { get; set; }
        public int Memory { get; set; }
        public string MemType { get; set; }
        public int BoostClock { get; set; }
        public int CoreClock { get; set; }
        public int Length { get; set; }
        public int TDP { get; set; }
        public int HDMIPorts { get; set; }
        public int DPPorts { get; set; }
        public string MaxRes { get; set; }
        public double Prix { get; set; }

        public Enfant(int Id, int IdParent, string Nom, string Description, enuChipsets Chipset, int Memory, string MemType, int BoostClock, int CoreClock, int Length, int TDP, int HDMIPorts, int DPPorts, string MaxRes, double Prix)
        {
            this.Id = Id;
            this.IdParent = IdParent;
            this.Nom = Nom;
            this.Description = Description;
            this.Chipset = Chipset;
            this.Memory = Memory;
            this.MemType = MemType;
            this.BoostClock = BoostClock;
            this.CoreClock = CoreClock;
            this.Length = Length;
            this.TDP = TDP;
            this.HDMIPorts = HDMIPorts;
            this.DPPorts = DPPorts;
            this.MaxRes = MaxRes;
            this.Prix = Prix;
        }

    }
}
