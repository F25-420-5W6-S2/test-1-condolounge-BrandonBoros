using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        [ForeignKey("BuildingId")]
        public int? BuildingId { get; set; }
    }
}
