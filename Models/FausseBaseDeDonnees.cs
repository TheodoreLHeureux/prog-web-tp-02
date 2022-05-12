using System.Collections.Generic;
using System.Linq;


namespace prog_web_tp_2.Models
{
    public class FausseBaseDeDonnees
    {
        private const string DescAsus = "Asus est une entreprise taïwanaise qui produit notamment les cartes graphiques ROG (Republic Of Gamers) et TUF (The Ultimate Force).";
        private const string DescGigabyte = "Gigabyte est une entreprise taïwanaise dont le revenu annuel est d'environ 84 milliards. Ce sont eux qui produisent les cartes graphiques AORUS.";
        private const string DescEVGA = "EVGA Corporation est une compagnie californienne. Cette compagnie est plus petite que les autres, mais elle est souvent reconnue pour son service à la clientèle.";

        private const string DescVisionOC = "La puissante GeForce RTX™ Série 30 VISION accélère votre travail grâce à des performances incroyables. Que ce soit MONTAGE VIDÉO, ANIMATION 3D, PHOTOGRAPHIE, CONCEPTION GRAPHIQUE, ARCHITECTURE ou STREAMING, elle peut vous faire gagner beaucoup de temps.";

        private const string DescEVGA3060 = "The EVGA GeForce® RTX 3060 12GB provides players with the ability to vanquish 1080p and 1440p gaming, while providing a quality NVIDIA RTX™ experience and a myriad of productivity benefits. The card is powered by NVIDIA Ampere architecture, which doubles down on ray tracing and AI performance with enhanced RT cores, Tensor Cores, and new streaming multiprocessors. With 12GB of GDDR6 memory, high-end performance does not have to be sacrificed to find a card for gaming and everyday use.";
        private const string DescEVGA3070 = "The EVGA GeForce RTX™ 3070 is powered by the NVIDIA Ampere architecture. Built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and high-speed G6 memory, it gives you the power you need to rip through the most demanding games at 1440p resolution. Combined with the next generation of design, cooling, and overclocking with EVGA Precision X1, the EVGA GeForce RTX™ 3070 Series creates a definition for ultimate performance.";
        private const string DescEVGA3080 = "Introducing the EVGA GeForce RTX™ 3080 12GB graphics cards - Built for and designed for gamers. The new GeForce RTX™ 3080 12GB features 20% more VRAM compared to the GeForce RTX™ 3080, more CUDA cores, and faster memory bandwidth to provide more performance headroom for high-resolution gaming and more demanding visual quality settings.";
        private const string DescEVGA3090 = "The EVGA GeForce® RTXᐪᔿ 30 Series Graphics Cards have arrived. These new cards are colossally powerful in every way, giving you a whole new tier of performance.They are powered by the NVIDIA® Ampere architecture, which doubles down on ray tracing and AI performance with enhanced RT Cores, Tensor Cores, and new streaming multiprocessors.";

        private const string DescAsus3060 = "From top to bottom, the ROG Strix GeForce RTX™️ 3060 has been designed to push performance boundaries. A fresh design and more metal surrounds a grouping of Axial-tech fans that leverage a new rotation scheme. Below the blades, a larger, more impressive heatsink is ready for the most demanding thermal loads. The PCB has some new tricks up its sleeves, and even the backplate has received some performance-boosting changes. For gamers who want to get the most out of the NVIDIA Ampere architecture, the latest addition to the ROG Strix stable delivers in every way.";
        private const string DescAsus3070 = "This limited edition of the ROG Strix GeForce RTX™ 3070 features a completely white colorway on top of all the generational improvements to the ROG Strix series. Now’s your chance to build a high-end white-themed gaming rig with the latest in graphics technology.";
        private const string DescAsus3080 = "This limited edition of the ROG Strix GeForce RTX™ 3080 features a completely white colorway on top of all the generational improvements to the ROG Strix series. Now’s your chance to build a high-end white-themed gaming rig with the latest in graphics technology.";
        private const string DescAsus3090 = "This limited edition of the ROG Strix GeForce RTX™ 3090 features a completely white colorway on top of all the generational improvements to the ROG Strix series. Now’s your chance to build a high-end white-themed gaming rig with the latest in graphics technology.";

        public List<Parent> Parents { get; set; }
        public List<Enfant> Enfants { get; set; }

        public FausseBaseDeDonnees()
        {

            Parents = new List<Parent>
            {
                new Parent(0, "Asus", "/images/asus.png", DescAsus),
                new Parent(1, "Gigabyte", "/images/gigabyte.png", DescGigabyte),
                new Parent(2, "EVGA", "/images/evga.png", DescEVGA)
            };

            Enfants = new List<Enfant>
            {
                new Enfant { Id = 0, IdParent = 1, Nom = "RTX 3060 Vision OC", Description = DescVisionOC, Chipset = (enuChipsets)0, Memory = 12, MemType = "GDDR6", BoostClock = 1837, CoreClock = 1320, Length = 286, TDP = 170, HDMIPorts = 2, DPPorts = 2, MaxRes = "8K", Prix = 499.99, Premium = false },
                new Enfant { Id = 1, IdParent = 1, Nom = "RTX 3070 Vision OC", Description = DescVisionOC, Chipset = (enuChipsets)1, Memory = 8, MemType = "GDDR6", BoostClock = 1815, CoreClock = 1500, Length = 286, TDP = 220, HDMIPorts = 2, DPPorts = 2, MaxRes = "8K", Prix = 779.99, Premium = false },
                new Enfant { Id = 2, IdParent = 1, Nom = "RTX 3080 Vision OC", Description = DescVisionOC, Chipset = (enuChipsets)2, Memory = 10, MemType = "GDDR6X", BoostClock = 1800, CoreClock = 1440, Length = 320, TDP = 320, HDMIPorts = 2, DPPorts = 3, MaxRes = "8K", Prix = 1099.99, Premium = false },
                new Enfant { Id = 3, IdParent = 1, Nom = "RTX 3090 Vision OC", Description = DescVisionOC, Chipset = (enuChipsets)3, Memory = 8, MemType = "GDDR6X", BoostClock = 1815, CoreClock = 1500, Length = 286, TDP = 220, HDMIPorts = 2, DPPorts = 2, MaxRes = "8K", Prix = 2199.99, Premium = true },
                new Enfant { Id = 4, IdParent = 0, Nom = "RTX 3060 Strix Gaming OC", Description = DescAsus3060, Chipset = (enuChipsets)0, Memory = 12, MemType = "GDDR6", BoostClock = 1912, CoreClock = 1320, Length = 300, TDP = 170, HDMIPorts = 2, DPPorts = 3, MaxRes = "8K", Prix = 688.99, Premium = false},
                new Enfant { Id = 5, IdParent = 0, Nom = "RTX 3070 Strix OC White", Description = DescAsus3070, Chipset = (enuChipsets)1, Memory = 8, MemType = "GDDR6", BoostClock = 1935, CoreClock = 1500, Length = 319, TDP = 220, HDMIPorts = 2, DPPorts = 3, MaxRes = "8K", Prix = 877.05, Premium = false },
                new Enfant { Id = 6, IdParent = 0, Nom = "RTX 3080 Strix OC White", Description = DescAsus3080, Chipset = (enuChipsets)2, Memory = 10, MemType = "GDDR6X", BoostClock = 1710, CoreClock = 1440, Length = 286, TDP = 320, HDMIPorts = 2, DPPorts = 3, MaxRes = "8K", Prix = 1299.99, Premium = false },
                new Enfant { Id = 7, IdParent = 0, Nom = "RTX 3090 Strix OC White", Description =  DescAsus3090, Chipset = (enuChipsets)3, Memory = 24, MemType = "GDDR6X", BoostClock = 1890, CoreClock = 1395, Length = 319, TDP = 350, HDMIPorts = 2, DPPorts = 3, MaxRes = "8K", Prix = 2449.99, Premium = true },
                new Enfant { Id = 8, IdParent = 2, Nom = "RTX 3060 XC Black Gaming", Description = DescEVGA3060, Chipset = (enuChipsets)0, Memory = 12, MemType = "GDDR6", BoostClock = 1777, CoreClock = 1320, Length = 202, TDP = 170, HDMIPorts = 1, DPPorts = 3, MaxRes = "8K", Prix = 399.99, Premium = false },
                new Enfant { Id = 9, IdParent = 2, Nom = "RTX 3070 FTW3 Ultra Gaming", Description = DescEVGA3070, Chipset = (enuChipsets)1, Memory = 8, MemType = "GDDR6", BoostClock = 1815, CoreClock = 1500, Length = 300, TDP = 220, HDMIPorts = 1, DPPorts = 3, MaxRes = "8K", Prix = 719.99, Premium = false },
                new Enfant { Id = 10, IdParent = 2, Nom = "RTX 3080 FTW3 Ultra Gaming", Description = DescEVGA3080, Chipset = (enuChipsets)2, Memory = 10, MemType = "GDDR6X", BoostClock = 1800, CoreClock = 1440, Length = 300, TDP = 320, HDMIPorts = 1, DPPorts = 3, MaxRes = "8K", Prix = 919.99, Premium = false },
                new Enfant { Id = 11, IdParent = 2, Nom = "RTX 3090 FTW3 Ultra Gaming", Description = DescEVGA3090, Chipset = (enuChipsets)3, Memory = 24, MemType = "GDDR6X", BoostClock = 1800, CoreClock = 1395, Length = 300, TDP = 350, HDMIPorts = 1, DPPorts = 3, MaxRes = "8K", Prix = 1919.99, Premium = true }

            };

            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }

            foreach (var e in Enfants)
            {
                e.Parent = Parents.Single(p => p.Id == e.IdParent);
                e.ImageURL = "/images/GPUs/" + e.Parent.Nom.Replace(' ', '-') + "/" + e.Nom.Replace(' ', '-') + "/" + e.Nom.Replace(' ', '-') + "-1.jpg";
            }

        }
    }
}
