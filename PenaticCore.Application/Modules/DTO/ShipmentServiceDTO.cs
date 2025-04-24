using PenaticCore.Domain.Helpers;

namespace PenaticCore.Application.Modules.DTO
{
    public class ShipmentServiceDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ShipmentServiceType type { get; set; }
        public int TransitTimeMinHours { get; set; }
        public int TransitTimeMaxHours { get; set; }
    }
}
