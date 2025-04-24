namespace PenaticCore.Domain.Models
{
    public class ShipmentRate : EntityBase
    {
        public string ShipmentServiceId { get; set; }
        public ShipmentService ShipmentService { get; set; }
        public string ShipmentDetailId { get; set; }
        public ShipmentDetail ShipmentDetail { get; set; }
        public double TotalAmount { get; set; }

    }
}
