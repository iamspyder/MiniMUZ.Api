namespace MiniMUZ.Api.MuzModels.DTO.Item
{
    public class ItemDTO
    {
        public int ItemIdDTO { get; set; }

        public string? ItemNameDTO { get; set; }

        public string? ItemTypeDTO { get; set; }

        public DateTime? AddedDateDTO { get; set; }

        public int? ShipmentIdDTO { get; set; }

        public int? QuantityDTO { get; set; }

        public int? SpaceDTO { get; set; }
    }
}
