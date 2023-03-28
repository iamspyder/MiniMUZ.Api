using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels.DTO.Dispatch;
using MiniMUZ.Api.MuzModels.Repository;

namespace MiniMUZ.Api.MuzModels.Data_Manager
{
    public class DDispatch : IMuz<Dispatch, DispatchDTO>
    {
        private readonly MiniMuzContext _dbcontext;

        public DDispatch(MiniMuzContext context)
        {
            _dbcontext = context;
        }
        public void Add(Dispatch entity)
        {
            throw new NotImplementedException();
        }

        public void Adds(DispatchDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Dispatch entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Dispatch Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dispatch> GetAll()
        {
            return _dbcontext.Dispatches.ToList();
        }

        public Dispatch GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DispatchDTO GetDto(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Dispatch entity)
        {
            throw new NotImplementedException();
        }
    }
}
