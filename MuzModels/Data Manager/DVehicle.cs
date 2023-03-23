using Microsoft.EntityFrameworkCore;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.DTO.Vehicle;
using MiniMUZ.Api.MuzModels.Repository;

namespace MiniMUZ.Api.Repository
{
    public class DVehicle : IMuz<Vehicle,VehiceDTO>
    {
        private readonly MiniMuzContext _dbcontext;

        public DVehicle(MiniMuzContext context)
        {
            _dbcontext = context;
        }



        // creted a concrete class 

        public void Add(MuzModels.Vehicle vehicle)
        {
            _dbcontext.Vehicles.Add(vehicle);
            _dbcontext.SaveChanges();
          
        }

        public void Adds(VehiceDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MuzModels.Vehicle vehicle)
        {

            _dbcontext.Vehicles.Remove(vehicle);
            _dbcontext.SaveChanges();

        }

        public void DeleteById(int id)
        {
            var customer = GetById(id);
            Delete(customer);
          
        }

        public Vehicle Get(long id)
        {
            var vehicle = _dbcontext.Vehicles
               .SingleOrDefault(b => b.VehicleId == id);

            return vehicle;
           
        }

        public IEnumerable<MuzModels.Vehicle> GetAll()
        {
            return _dbcontext.Vehicles.ToList();
        }

        public MuzModels.Vehicle GetById(int id)
        {
            return _dbcontext.Vehicles.Find(id);
        }

        public VehiceDTO GetDto(long id)
        {
            _dbcontext.ChangeTracker.LazyLoadingEnabled = true;

            using (var context = new MiniMuzContext())
            {
                var vehicle = context.Vehicles
                    .SingleOrDefault(b => b.VehicleId == id);

                return VehicleDTOmapper.MapToDto(vehicle);
            }
            throw new NotImplementedException();
        }

      

        public void Update(Vehicle entity, Vehicle vehicle)
        {
            _dbcontext.Entry(vehicle).State = EntityState.Modified;
            _dbcontext.SaveChanges();

        }

        public void Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
