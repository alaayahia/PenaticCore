namespace PenaticCore.Domain.Models
{
    public class ShipmentDetail : EntityBase
    {
        public string OriginRegionId { get; set; }
        public Region OriginRegion { get; set; }
        public string DestinationRegionId { get; set; }
        public Region DestinationRegion { get; set; }
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
