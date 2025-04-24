using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.DTO.RequestDTO
{
    public class ShipmentRateRequestDTO 
    {
        public string ShipmentServiceId { get; set; }
        public string ShipmentDetailId { get; set; }
        public double TotalAmount { get; set; }
    }
}
