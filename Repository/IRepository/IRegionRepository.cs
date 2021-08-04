using EFObjects.Tables;
using System.Linq;


    namespace Repository.IRepository
    {
        public interface IRegionRepository
        {
            IQueryable<Region> GetRegions();
        }
    }