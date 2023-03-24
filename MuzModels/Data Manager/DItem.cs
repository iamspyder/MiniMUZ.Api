using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels.DTO.Item;
using MiniMUZ.Api.MuzModels.DTO.Shipment;
using MiniMUZ.Api.MuzModels.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MiniMUZ.Api.MuzModels.Data_Manager
{
    public class DItem : IMuz<Item, ItemDTO>
    {

        private readonly MiniMuzContext _dbcontext;

        public DItem(MiniMuzContext context)
        {
            _dbcontext = context;
        }

        public void Add(Item entity)
        {
            throw new NotImplementedException();
        }

      

        public void Adds(ItemDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Item entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Item Get(long id)
        {
          
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            var a = 4;
            var Q = _dbcontext.Items.Where(item => item.ShipmentId == a);
            return Q.ToList();

          //  return _dbcontext.Items.ToList();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ItemDto GetDto(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }

        ItemDTO IMuz<Item, ItemDTO>.GetDto(long id)
        {
            throw new NotImplementedException();
        }
    }
}
