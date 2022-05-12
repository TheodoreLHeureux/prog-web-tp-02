using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace prog_web_tp_2.Models
{
    public class Enfant
    {

        [Display(Name = "Id de la carte")]
        public int Id { get; set; }

        [Display(Name = "Id du parent")]
        [Range(0, 2, ErrorMessage = "Parent invalide.")]
        [Required(ErrorMessage = "Un Id doit être spécifié.")]
        public int IdParent
        {
            get;
            set;
        }

        [Display(Name = "Manufacturée par : ")]
        public Parent Parent { get; set; }

        [Display(Name = "Url de l'image")]
        [DataType(DataType.ImageUrl, ErrorMessage = "L'URL entrée est invalide")]
        [Required(ErrorMessage = "Une image doit être spécifiée.")]
        public string ImageURL { get; set; }

        [Display(Name = "Nom de la carte")]
        [Required (ErrorMessage = "Un nom doit être spécifié.")]
        [MaxLength(50, ErrorMessage = "Le nom doit faire moins de 50 charactères.")]
        public string Nom { get; set; }

        [Display(Name = "Description de la carte")]
        [Required (ErrorMessage = "Une description doit être spécifiée.")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "La description doit faire moins de 500 charactères.")]
        public string Description { get; set; }

        [Display(Name = "Chipset de la carte")]
        [Required (ErrorMessage = "Un chipset doit être spécifié.")]
        public enuChipsets Chipset { get; set; }

        [Display(Name = "Mémoire vidéo en GB")]
        [Required (ErrorMessage = "La mémoire doit être spécifiée.")]
        [Range(1, 100, ErrorMessage = "La quantitée de mémoire doit être entre 1 t 100 GB.")]        
        public int Memory { get; set; }

        [Display(Name = "Type de la mémoire vidéo")]
        [Required (ErrorMessage = "Un type de mémoire doit être spécifié.")]
        [MaxLength(10, ErrorMessage = "Ne doit pas faire plus de 10 charactères.")]
        public string MemType { get; set; }

        [Display(Name = "Boost clock de la carte en MHz")]
        [Required (ErrorMessage = "Un boost clock doit être spécifié.")]
        [Range(1, 10000, ErrorMessage = "Doit être entre 1 et 10 000.")]
        public int BoostClock { get; set; }

        [Display(Name = "Core clock de la carte en MHz")]
        [Required (ErrorMessage = "Un core clock doit être spécifié.")]
        [Range(1, 10000, ErrorMessage = "Doit être entre 1 et 10 000.")]
        public int CoreClock { get; set; }

        [Display(Name = "Longueur de la carte en millimètres")]
        [Required (ErrorMessage = "Une longueur doit être spécifiée.")]
        [Range(1, 600, ErrorMessage = "Doit être entre 1 et 600.")]
        public int Length { get; set; }

        [Display(Name = "TDP de la carte en Watts")]
        [Required (ErrorMessage = "Un TDP doit être spécifié.")]
        [Range(1, 5000, ErrorMessage = "Doit être entre 1 et 5 000.")]
        public int TDP { get; set; }

        [Display(Name = "Nombre de port(s) de sortie HDMI")]
        [Required (ErrorMessage = "Un nombre de ports HDMI doit être spécifié.")]
        [Range(1, 20, ErrorMessage = "Doit être entre 1 et 20.")]
        public int HDMIPorts { get; set; }

        [Display(Name = "Nombre de port(s) de sortie DisplayPort")]
        [Required (ErrorMessage = "Un nombre de ports DisplayPort doit être spécifié.")]
        [Range(1, 20, ErrorMessage = "Doit être entre 1 et 20.")]
        public int DPPorts { get; set; }

        [Display(Name = "Résolution maximale de la carte graphique")]
        [Required (ErrorMessage = "Une résolution doit être spécifiée.")]
        [MaxLength(10, ErrorMessage = "Ne doit pas faire plus de 10 charactères.")]
        public string MaxRes { get; set; }

        [Display(Name = "Prix de la carte")]
        [Required (ErrorMessage = "Un prix doit être spécifié.")]
        [Range(1, 100000, ErrorMessage = "Doit être entre 1 et 100 000.")]
        public double Prix { get; set; }

        [Display(Name = "Est-ce une carte premium ?")]
        [Required (ErrorMessage = "Le status doit être spécifié.")]
        public bool Premium { get; set; }


        //public Enfant(int Id, int IdParent, string Nom, string Description, enuChipsets Chipset, int Memory, string MemType, int BoostClock, int CoreClock, int Length, int TDP, int HDMIPorts, int DPPorts, string MaxRes, double Prix, bool Premium)
        //{
        //    this.Id = Id;
        //    this.IdParent = IdParent;
        //    this.Nom = Nom;
        //    this.Description = Description;
        //    this.Chipset = Chipset;
        //    this.Memory = Memory;
        //    this.MemType = MemType;
        //    this.BoostClock = BoostClock;
        //    this.CoreClock = CoreClock;
        //    this.Length = Length;
        //    this.TDP = TDP;
        //    this.HDMIPorts = HDMIPorts;
        //    this.DPPorts = DPPorts;
        //    this.MaxRes = MaxRes;
        //    this.Prix = Prix;
        //    this.Premium = Premium;
        //}

    }
}
