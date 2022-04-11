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
                new Enfant(0, 1, "RTX 3060 Vision OC", DescVisionOC, (enuChipsets)0, 12, "GDDR6", 1837, 1320, 286, 170, 2, 2, "8K", 499.99),
                new Enfant(1, 1, "RTX 3070 Vision OC", DescVisionOC, (enuChipsets)1, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 779.99),
                new Enfant(2, 1, "RTX 3080 Vision OC", DescVisionOC, (enuChipsets)2, 10, "GDDR6X", 1800, 1440, 320, 320, 2, 3, "8K", 1099.99),
                new Enfant(3, 1, "RTX 3090 Vision OC", DescVisionOC, (enuChipsets)3, 8, "GDDR6X", 1815, 1500, 286, 220, 2, 2, "8K", 2199.99),
                new Enfant(4, 0, "RTX 3060 Strix Gaming OC", DescAsus3060, (enuChipsets)0, 12, "GDDR6", 1912, 1320, 300, 170, 2, 3, "8K", 688.99),
                new Enfant(5, 0, "RTX 3070 Strix OC White", DescAsus3070, (enuChipsets)1, 8, "GDDR6", 1935, 1500, 319, 220, 2, 3, "8K", 877.05),
                new Enfant(6, 0, "RTX 3080 Strix OC White", DescAsus3080, (enuChipsets)2, 10, "GDDR6X", 1710, 1440, 286, 320, 2, 3, "8K", 1299.99),
                new Enfant(7, 0, "RTX 3090 Strix OC White", DescAsus3090, (enuChipsets)3, 24, "GDDR6X", 1890, 1395, 319, 350, 2, 3, "8K", 2449.99),
                new Enfant(8, 2, "RTX 3060 XC Black Gaming", DescEVGA3060, (enuChipsets)0, 12, "GDDR6", 1777, 1320, 202, 170, 1, 3, "8K", 399.99),
                new Enfant(9, 2, "RTX 3070 FTW3 Ultra Gaming", DescEVGA3070, (enuChipsets)1, 8, "GDDR6", 1815, 1500, 300, 220, 1, 3, "8K", 719.99),
                new Enfant(10, 2, "RTX 3080 FTW3 Ultra Gaming", DescEVGA3080, (enuChipsets)2, 10, "GDDR6X", 1800, 1440, 300, 320, 1, 3, "8K", 919.99),
                new Enfant(11, 2, "RTX 3090 FTW3 Ultra Gaming", DescEVGA3090, (enuChipsets)3, 24, "GDDR6X", 1800, 1395, 300, 350, 1, 3, "8K", 1919.99)
            };

            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }

            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
                e.ImageURL = "/images/GPUs/" + e.Parent.Nom.Replace(' ', '-') + "/" + e.Nom.Replace(' ', '-') + "/" + e.Nom.Replace(' ', '-') + "-1.jpg";
            }

        }
    }
}
