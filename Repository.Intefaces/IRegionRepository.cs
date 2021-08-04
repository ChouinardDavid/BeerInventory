using System.Linq;
using EFObjects.Tables;

namespace Repository
{
    public interface IRegionRepository
    {
        IQueryable<Region> GetRegions();
    }
}