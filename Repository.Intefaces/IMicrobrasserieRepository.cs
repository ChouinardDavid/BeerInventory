using EFObjects.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Intefaces
{
    public interface IMicrobrasserieRepository
    {
        void AjouterMicrobrasserie(Microbrasserie micro);
        IEnumerable<Microbrasserie> GetMicrobrasserie();
        IEnumerable<Microbrasserie> GetMicrobrasserie(Region region);
        Microbrasserie GetMicrobrasserie(int id);
        void UpdateMicrobrasserie(Microbrasserie micro);
        void DeleteMicrobrasserie(Microbrasserie micro);
    }
}
