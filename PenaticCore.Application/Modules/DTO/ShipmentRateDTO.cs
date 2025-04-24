using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.DTO
{
    public class ShipmentRateDTO : BaseDTO
    {

        public string ShipmentServiceId { get; set; }
        public ShipmentServiceDTO ShipmentService { get; set; }
        public string ShipmentDetailId { get; set; }
        public ShipmentDetailDTO ShipmentDetail { get; set; }
        public double TotalAmount { get; set; }
    }
}
