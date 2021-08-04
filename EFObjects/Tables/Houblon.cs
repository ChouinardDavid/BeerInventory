using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EFObjects.Tables
{
    public class Houblon
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }

        //Clés étrangères
        public virtual List<Biere> Bieres { get; set; }
    }
}