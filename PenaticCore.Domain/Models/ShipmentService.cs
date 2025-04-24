using PenaticCore.Domain.Helpers;

namespace PenaticCore.Domain.Models
{
    public class ShipmentService : EntityBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ShipmentServiceType type { get; set; }
        public int TransitTimeMinHours { get; set; }    
        public int TransitTimeMaxHours { get; set; }
    }
}
