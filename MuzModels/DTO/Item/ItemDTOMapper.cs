using MiniMUZ.Api.MuzModels.DTO.Item;

namespace MiniMUZ.Api.MuzModels.DTO.Item
{
    public class ItemDTOMapper
    {
        public static ItemDTO MapToDto(MuzModels.Item item)
        {
            return new ItemDTO()
            {
                ItemIdDTO= item.ItemId,
                ItemNameDTO= item.ItemName,
                ItemTypeDTO= item.ItemType,
                ShipmentIdDTO= item.ShipmentId,
                AddedDateDTO= item.AddedDate,
                QuantityDTO= item.Quantity,
                SpaceDTO= item.Space,

            };
        }
    }
}
