namespace MiniMUZ.Api.MuzModels.DTO.Shipment
{
    public class ShipmentDTO
    {
       
            public int? DtoShipmentNo { get; set; }
            public string? DtoShipmentName { get; set; }

            public int? DtoWuId { get; set; }

            public DateTime? DtoDatetime { get; set; }
            public IList<ItemDto> Items { get; set; } = new List<ItemDto>();


    }

    public class ItemDto
    {
        public int? DtoItemID { get; set; }
        public string? DtoItemName { get; set; }

        public string? DtoItemType { get; set; }

        public DateTime? DtoDate { get; set; }

        public int? DtoShipmentID { get; set; }

        public int? DtoQuantity { get; set; }

        public int? DtoSapce { get; set; }
    }
}
