using System.ComponentModel.DataAnnotations;

namespace PenaticCore.Domain.Models
{
    public class Region : EntityBase
    {
        public string Name { get; set; }
        public string EmirateId { get; set; }
        public Emirate Emirate { get; set; }
        [Required]
        public string? RegionCode { get; set; }
    }
}
