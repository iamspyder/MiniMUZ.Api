using Microsoft.AspNetCore.Mvc;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.DTO;
using MiniMUZ.Api.MuzModels.Repository;

namespace MiniMUZ.Api.Controllers
{
    [Route("api/Vehicle")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IMuz<Vehicle,MuzModels.DTO.Vehicle.VehiceDTO> _dVehicle ;

        public VehicleController(IMuz<Vehicle, MuzModels.DTO.Vehicle.VehiceDTO> muz)
        {
            _dVehicle = muz;
        }



        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var Vehicle = _dVehicle.GetAll();
                return Ok(Vehicle);

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {


            try
            {
                if (vehicle is null)
                {
                    return BadRequest("Vehicle is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                _dVehicle.Add(vehicle);
                return Ok();

            }
            catch (Exception ex)
            {

                throw ex;
            }
          
            //return Ok(vehicle);
        }


        // Get BY ID using DTO

        [HttpGet("{id}", Name = "GetVehicleByID")]
        public IActionResult Get(int id)
        {
            var vehicle = _dVehicle.GetDto(id);
            if (vehicle == null)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok(vehicle);
        }

      

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest("Vehicle is null.");
            }

            var vehicletoid = _dVehicle.GetDto(id);
            if (vehicletoid == null)
            {
                return NotFound("The Vehicle record couldn't be found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

           _dVehicle.Update(vehicle,vehicle);
            return NoContent();
        }
    }
}
