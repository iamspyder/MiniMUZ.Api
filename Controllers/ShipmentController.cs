using Microsoft.AspNetCore.Mvc;
using MiniMUZ.Api.MuzModels.Repository;
using MiniMUZ.Api.MuzModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using MiniMUZ.Api.MuzModels.DTO.Shipment;
using MiniMUZ.Api.Repository;

namespace MiniMUZ.Api.Controllers
{

    [Route("api/Shipment")]
    [ApiController]
    public class ShipmentController : Controller
    {
        private readonly IMuz<Shipment, MuzModels.DTO.Shipment.ShipmentDTO> _dShipment;

        public ShipmentController(IMuz<Shipment, MuzModels.DTO.Shipment.ShipmentDTO> muz)
        {
            _dShipment = muz;
        }



        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var shipm = _dShipment.GetAll();
                return Ok(shipm);

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        [HttpPost]
        public IActionResult Post(ShipmentDTO shipmentDTO)
        {


            try
            {
                if (shipmentDTO is null)
                {
                    return BadRequest("Vehicle is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                _dShipment.Adds(shipmentDTO);
                return Ok();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            //return Ok(vehicle);
        }

    }
}
