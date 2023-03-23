using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels.DTO.Shipment;
using MiniMUZ.Api.MuzModels.DTO.Vehicle;
using MiniMUZ.Api.MuzModels.Repository;
using System.Diagnostics;

namespace MiniMUZ.Api.MuzModels.Data_Manager
{
    public class DShipment : IMuz<Shipment, ShipmentDTO>
    {


        private readonly MiniMuzContext _dbcontext;

        public DShipment(MiniMuzContext context)
        {
            _dbcontext = context;
        }

       

        
      

        public void Add(Shipment entity)
        {
            throw new NotImplementedException();
        }

        public void Adds(ShipmentDTO entity)
        {
            var model = new Shipment
            {
                ShipmentId = entity.DtoShipmentNo,
                ShipmentName = entity.DtoShipmentName,
                ShipmentDate = entity.DtoDatetime,
                Uwid = entity.DtoWuId,


            };
            foreach (var itemdto in entity.Items)
            {
                model.Items.Add(new Item
                {
                    ItemId = itemdto.DtoItemID,
                    ItemName = itemdto.DtoItemName,
                    ItemType = itemdto.DtoItemType,
                    AddedDate = itemdto.DtoDate,
                    Quantity = itemdto.DtoQuantity,
                    ShipmentId = itemdto.DtoShipmentID,
                    Space = itemdto.DtoSapce

                });
            }

            _dbcontext.Shipments.Add(model);
            _dbcontext.SaveChanges();
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

        public void Update(Shipment entity)
        {
            throw new NotImplementedException();
        }
    }
}
