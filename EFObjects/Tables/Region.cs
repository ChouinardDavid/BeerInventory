using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFObjects.Tables
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        //public string test { get; set; }

        //Clés étrangères
        public virtual List<Microbrasserie> Microbrasseries{ get; set; }

    }
}