using System.ComponentModel.DataAnnotations;

namespace PenaticCore.Domain.Models
{
    public class Emirate : EntityBase
    {
        public string Name { get; set; }
        [Required]
        public string? CountryCode { get; set; }

    }
}
