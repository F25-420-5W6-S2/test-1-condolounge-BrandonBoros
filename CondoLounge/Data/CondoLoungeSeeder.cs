using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace CondoLounge.Data
{
    public class CondoLoungeSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoLoungeSeeder(ApplicationDbContext context,
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            // db exists
            _db.Database.EnsureCreated();

            // add roles if theres none
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
            }

            // add users if theres none
            if (!_userManager.Users.Any())
            {
                var adminUser = new ApplicationUser() { UserName = "admin@email.com", Email = "admin@email.com"};                
                await _userManager.CreateAsync(adminUser, "VerySecureAdmin45%");  
                await _userManager.AddToRoleAsync(adminUser, "Admin");

                var normalUser = new ApplicationUser() { UserName = "normal@email.com", Email = "normal@email.com" };
                await _userManager.CreateAsync(normalUser, "VerySecureNormal45%");
                await _userManager.AddToRoleAsync(normalUser, "Default");
            }

            // populates condos if none
            if (!_db.Condos.Any())
            {
                // create sample condos
                var condos = new List<Condo>()
                {
                    new Condo()
                    {
                        CondoNumber = 1,
                    },
                    new Condo()
                    {
                        CondoNumber = 2,
                    },
                    new Condo()
                    {
                        CondoNumber = 3,
                    },
                };

                _db.Condos.AddRange(condos);

                // need copy for second building
                var condos2 = new List<Condo>()
                {
                    new Condo()
                    {
                        CondoNumber = 1,
                    },
                    new Condo()
                    {
                        CondoNumber = 2,
                    },
                    new Condo()
                    {
                        CondoNumber = 3,
                    },
                };

                // user lists to add to the building
                var users = new List<ApplicationUser>()
                {
                    _userManager.Users.First()
                };

                var users2 = new List<ApplicationUser>()
                {
                    _userManager.Users.OrderByDescending(u => u.UserName).First(),
                };

                // create sample buildings
                var buildings = new List<Building>()
                {
                    new Building()
                    {
                        Name = "BESTCONDO",
                        Condos = condos,
                        Users = users
                    },
                    new Building()
                    {
                        Name = "CondoPlus",
                        Condos = condos2,
                        Users = users2
                    }
                };
                    
                _db.Buildings.AddRange(buildings);

                _db.SaveChanges(); 
            }
        }
    }
}
