using PenaticCore.Domain.Helpers;
using System.ComponentModel.DataAnnotations;

namespace PenaticCore.Domain.Models
{
    public class ShipmentService : EntityBase
    {
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public ShipmentServiceType type { get; set; }
        public int TransitTimeMinHours { get; set; }    
        public int TransitTimeMaxHours { get; set; }
    }
}
