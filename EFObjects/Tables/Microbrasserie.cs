using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace EFObjects.Tables
{
    [DebuggerDisplay("Id={Id}, Nom={Nom}, Bieres={Bieres}, Region={Region}")]
    public partial class Microbrasserie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        
        //Clés étrangères
        public virtual List<Biere> Bieres { get; set; }
        [Display(Name = "Région")]
        public virtual Region Region { get; set; }
    }
}