using System.Collections.Generic;
using System.Linq;


namespace prog_web_tp_2.Models
{
    public class FausseBaseDeDonnees
    {
        private const string descAsus = "Asus est une entreprise taïwanaise qui produit notamment les cartes graphiques ROG (Republic Of Gamers) et TUF (The Ultimate Force).";
        private const string descGigabyte = "Gigabyte est une entreprise taïwanaise dont le revenu annuel est d'environ 84 milliards. Ce sont eux qui produisent les cartes graphiques AORUS.";
        private const string descEVGA = "EVGA Corporation est une compagnie californienne. Cette compagnie est plus petite que les autres, mais elle est souvent reconnue pour son service à la clientèle.";

        private const string descVisionOC = "La puissante GeForce RTX™ Série 30 VISION accélère votre travail grâce à des performances incroyables. Que ce soit MONTAGE VIDÉO, ANIMATION 3D, PHOTOGRAPHIE, CONCEPTION GRAPHIQUE, ARCHITECTURE ou STREAMING, elle peut vous faire gagner beaucoup de temps.";

        public List<Parent> Parents { get; set; }
        public List<Enfant> Enfants { get; set; }

        public FausseBaseDeDonnees()
        {

            Parents = new List<Parent>
            {
                new Parent(0, "Asus", "/images/asus.png", descAsus),
                new Parent(1, "Gigabyte", "/images/gigabyte.png", descGigabyte),
                new Parent(2, "EVGA", "/images/evga.png", descEVGA)
            };

            Enfants = new List<Enfant>
            {
                new Enfant(0, 1, "RTX 3060 Vision OC", descVisionOC, (enuChipsets)0, 12, "GDDR6", 1837, 1320, 286, 170, 2, 2, "8K", 499.99),
                new Enfant(1, 1, "RTX 3070 Vision OC", descVisionOC, (enuChipsets)1, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 779.99),
                new Enfant(2, 1, "RTX 3080 Vision OC", descVisionOC, (enuChipsets)2, 10, "GDDR6X", 1800, 1440, 320, 320, 2, 3, "8K", 1099.99),
                new Enfant(3, 1, "RTX 3090 Vision OC", descVisionOC, (enuChipsets)3, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 2199.99),
                new Enfant(4, 0, "RTX 3060 Strix Gaming OC", descVisionOC, (enuChipsets)0, 12, "GDDR6", 1912, 1320, 300, 170, 2, 3, "8K", 688.99),
                new Enfant(5, 0, "RTX 3070 Strix OC White", descVisionOC, (enuChipsets)1, 8, "GDDR6", 1935, 1500, 319, 220, 2, 3, "8K", 877.05),
                // Add data for entries below
                new Enfant(6, 0, "RTX 3080 Strix OC White", descVisionOC, (enuChipsets)2, 10, "GDDR6X", 1710, 1440, 286, 320, 2, 3, "8K", 780),
                new Enfant(7, 0, "RTX 3090 Strix OC White", descVisionOC, (enuChipsets)3, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 780),
                new Enfant(8, 2, "RTX 3060 XC Black Gaming", descVisionOC, (enuChipsets)0, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 780),
                new Enfant(9, 2, "RTX 3070 FTW3 Ultra Gaming", descVisionOC, (enuChipsets)1, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 780),
                new Enfant(10, 2, "RTX 3080 FTW3 Ultra Gaming", descVisionOC, (enuChipsets)2, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 780),
                new Enfant(11, 2, "RTX 3090 FTW3 Ultra Gaming", descVisionOC, (enuChipsets)3, 8, "GDDR6", 1815, 1500, 286, 220, 2, 2, "8K", 780)
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
