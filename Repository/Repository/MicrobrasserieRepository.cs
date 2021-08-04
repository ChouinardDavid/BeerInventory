using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using EFObjects.Tables;
using EFObjects.Context;
using Repository.IRepository;

namespace Repository
{
    public class MicrobrasserieRepository : IMicrobrasserieRepository
    {
        private readonly DBContext _context = DBContext.GetInstance();

        public void AjouterMicrobrasserie(Microbrasserie micro)
        {
            _context.Microbrasserie.Add(micro);
        }

        public IEnumerable<Microbrasserie> GetMicrobrasserie()
        {
            return _context.Microbrasserie.ToList<Microbrasserie>();
        }

        public Microbrasserie GetMicrobrasserie(int id)
        {
            return _context.Microbrasserie.Include(x => x.Region).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Microbrasserie> GetMicrobrasserie(Region region)
        {
            return _context.Microbrasserie.Include(x => x.Region).Where(x => x.Region == region);
        }

        public void UpdateMicrobrasserie(Microbrasserie micro)
        {
            try
            {
                var microBd = _context.Microbrasserie.Where(x => x.Id == micro.Id).First();
                micro.Region = _context.Regions.FirstOrDefault(x => x.Id == micro.Region.Id);
                microBd.UpdateMicro(micro);
                _context.Entry(microBd).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(ArgumentNullException e)
            {

            }
        }

        public void DeleteMicrobrasserie(Microbrasserie micro)
        {
            _context.Microbrasserie.Remove(micro);
        }
    }
}
