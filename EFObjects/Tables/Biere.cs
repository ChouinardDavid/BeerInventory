using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFObjects.Tables
{
    public class Biere
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        [Display(Name = "Appréciation")]
        public string Appreciation { get; set; }

        //Clés étrangères
        public virtual Volume Volume { get; set; }
        public virtual TypeBiere Type { get; set; }
        public virtual Microbrasserie Microbrasserie { get; set; }
        public virtual List<Houblon> Houblons  { get; set; }
    }
}