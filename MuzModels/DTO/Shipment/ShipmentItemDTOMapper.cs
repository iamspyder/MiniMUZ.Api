namespace MiniMUZ.Api.MuzModels.DTO.Shipment
{
    public class ShipmentItemDTOMapper
    {
        public static ShipmentDTO MapToDto( MuzModels.Shipment shipment)
        {
            var shipmentDto = new ShipmentDTO()
            {
                DtoShipmentNo = shipment.ShipmentId,
                DtoShipmentName = shipment.ShipmentName,
                DtoDatetime = shipment.ShipmentDate,
                DtoWuId = shipment.Uwid,
                Items = new List<ItemDto>()
            };

            foreach (var item in shipment.Items)
            {
                shipmentDto.Items.Add(new ItemDto()
                {
                    DtoItemID = item.ItemId,
                    DtoItemName = item.ItemName,
                    DtoItemType = item.ItemType,
                    DtoDate   = item.AddedDate,                    
                    DtoShipmentID = shipment.ShipmentId,
                    DtoQuantity = item.Quantity,
                    DtoSapce = item.Space
                });
            }

            return shipmentDto;
        }

    }
}

