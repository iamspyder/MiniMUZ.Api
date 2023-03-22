namespace MiniMUZ.Api.MuzModels.DTO.Shipment
{
    public class ShipmentDTO
    {
       
            public int DtoShipmentNo { get; set; }
            public string DtoShipmentName { get; set; }

            public string DtoWuId { get; set; }

            public string DtoDatetime { get; set; }
        public IList<ItemDto> Items { get; set; } = new List<ItemDto>();


    }

    public class ItemDto
    {
        public int DtoItemID { get; set; }
        public string DtoItemName { get; set; }

        public string DtoItemType { get; set; }

        public string DtoDate { get; set; }

        public int DtoShipmentID { get; set; }

        public int DtoQuantity { get; set; }

        public int DtoSapce { get; set; }
    }
}
