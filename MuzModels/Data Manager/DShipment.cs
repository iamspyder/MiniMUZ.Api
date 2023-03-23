using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels.DTO.Shipment;
using MiniMUZ.Api.MuzModels.DTO.Vehicle;
using MiniMUZ.Api.MuzModels.Repository;

namespace MiniMUZ.Api.MuzModels.Data_Manager
{
    public class DShipment : IMuz<Shipment, ShipmentDTO>
    {


        private readonly MiniMuzContext _dbcontext;

        public DShipment(MiniMuzContext context)
        {
            _dbcontext = context;
        }

        public void Adds(ShipmentDTO shipmentDTO)
        {
            try
            {
               
                var shipment = new Shipment
                {
                    ShipmentId = shipmentDTO.DtoShipmentNo,
                    ShipmentName = shipmentDTO.DtoShipmentName,
                    ShipmentDate = shipmentDTO.DtoDatetime,
                    Uwid = shipmentDTO.DtoWuId
                };


                _dbcontext.Shipments.Add(shipment);

                _dbcontext.SaveChanges();

               
                foreach (var itemDto in shipmentDTO.Items)
                {
                    var item = new Item
                    {
                        ItemId = itemDto.DtoItemID,
                        ItemName = itemDto.DtoItemName,
                        ItemType = itemDto.DtoItemType,
                        AddedDate = itemDto.DtoDate,
                        Quantity = itemDto.DtoQuantity,
                        Space = itemDto.DtoSpace,
                        ShipmentId = shipment.ShipmentId // set the foreign key to the new shipment's ID
                    };

                    _dbcontext.Items.Add(item);
                }

              
                _dbcontext.SaveChanges();

               
                return shipmentDTO;
            }
            catch (Exception ex)
            {
                // handle any exceptions
                return BadRequest(ex.Message);
            }
          //  throw new NotImplementedException();
        }

        public void Add(Shipment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shipment entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Shipment Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shipment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ShipmentDTO GetDto(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shipment entity, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
