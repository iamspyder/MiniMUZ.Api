namespace MiniMUZ.Api.MuzModels.DTO.Shipment
{
    public class ShipmentItemDTOMapper
    {
        public static ShipmentDTO MapToDto( MuzModels.Shipment shipment)
        {
            return new ShipmentDTO()
            {
                DtoShipmentNo = shipment.ShipmentId,
                DtoShipmentName = shipment.ShipmentName,
                DtoDatetime = shipment.ShipmentDate,
                DtoWuId = shipment.Uwid,
                

                Items = new ItemDto()
                {
                    DtoItemID = ,
                    Address = author.AuthorContact.Address,
                    ContactNumber = author.AuthorContact.ContactNumber
                }
            };
        }
    }
}
