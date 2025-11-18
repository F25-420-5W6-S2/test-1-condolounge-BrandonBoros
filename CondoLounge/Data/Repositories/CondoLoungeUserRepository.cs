using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeUserRepository : CondoLoungeGenericGenericRepository<ApplicationUser>, ICondoLoungeUserRepository
    {
        public CondoLoungeUserRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {
        }

        public IEnumerable<ApplicationUser> GetAllUsersInBuilding(int building)
        {
            return _dbSet.Where(u => u.BuildingId == building).ToList();
        }
    }
}
