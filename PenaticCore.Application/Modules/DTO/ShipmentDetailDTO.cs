using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.DTO
{
    public class ShipmentDetailDTO : BaseDTO
    {
        public string OriginRegionId { get; set; }
        public RegionDTO OriginRegion { get; set; }
        public string DestinationRegionId { get; set; }
        public RegionDTO DestinationRegion { get; set; }
        public double WeightValue { get; set; }
        public string WeightUnit { get; set; }
        public double LengthValue { get; set; }
        public double WidthValue { get; set; }
        public double HeightValue { get; set; }
        public string DimensionUnit { get; set; }
        public double Amount { get; set; }
        public string CurrencyName { get; set; }
    }
}
