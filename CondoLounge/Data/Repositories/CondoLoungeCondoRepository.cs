using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeCondoRepository : CondoLoungeGenericGenericRepository<Condo>, ICondoLoungeCondoRepository
    {
        public CondoLoungeCondoRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Condo>> logger) : base(db, logger)
        {
        }

        public IEnumerable<Condo> GetAllCondosInBuilding(int building)
        {
            return _dbSet.Where(c => c.BuildingId == building).ToList();
        }
    }
}
