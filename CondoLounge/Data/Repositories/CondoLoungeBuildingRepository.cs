using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeBuildingRepository : CondoLoungeGenericGenericRepository<Building>, ICondoLoungeBuildingRepository
    {
        public CondoLoungeBuildingRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }
    }
}
