using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFObjects.Tables
{
    public partial class Microbrasserie
    {
        public void UpdateMicro(Microbrasserie micro)
        {
            this.Region = micro.Region;
            this.Nom = micro.Nom;
        }
    }
}
