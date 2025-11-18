using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int Id { get; set; }
        public int CondoNumber { get; set; }
        
        [ForeignKey("BuildingId")]
        public int BuildingId { get; set; }
    }
}
