namespace PenaticCore.Domain.Models
{
    public class Region : EntityBase
    {
        public string Name { get; set; }
        public string EmirateId { get; set; }
        public Emirate Emirate { get; set; }
        public string? RegionCode { get; set; }
    }
}
