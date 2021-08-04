using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFObjects.Tables
{
    public class Volume
    {
        [Key]
        public int Id { get; set; }
        public string Quantite { get; set; }

        //Clés étrangères
        public virtual List<Biere> Bieres { get; set; }
    }
}