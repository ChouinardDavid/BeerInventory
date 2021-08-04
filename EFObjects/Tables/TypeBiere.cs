using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Web;

namespace EFObjects.Tables
{
    public class TypeBiere
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        //Clés étrangères
        public virtual List<Biere> Bieres { get; set; }
    }
}