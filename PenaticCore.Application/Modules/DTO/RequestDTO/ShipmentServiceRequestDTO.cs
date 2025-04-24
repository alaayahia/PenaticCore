using PenaticCore.Domain.Helpers;

namespace PenaticCore.Application.Modules.DTO.RequestDTO
{
    public class ShipmentServiceRequestDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ShipmentServiceType type { get; set; }
        public int TransitTimeMinHours { get; set; }
        public int TransitTimeMaxHours { get; set; }
    }
}
