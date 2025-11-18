namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public required ICollection<Condo> Condos { get; set; }
    }
}
