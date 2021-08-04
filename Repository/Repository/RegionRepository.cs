using EFObjects.Context;
using EFObjects.Tables;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RegionRepository : IRegionRepository
    {
        DBContext _context = DBContext.GetInstance(); 

        public IQueryable<Region> GetRegions()
        {
            return _context.Regions;
        }
    }
}
