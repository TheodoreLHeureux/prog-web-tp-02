using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_web_tp_2.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public List<Enfant> Enfants { get; set; }
        public string Nom { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        public Parent(int Id, string Nom, string ImageURL, string Description)
        {
            this.Id = Id;
            this.Enfants = new List<Enfant>();
            this.Nom = Nom;
            this.ImageURL = ImageURL;
            this.Description = Description;
        }

    }
}
