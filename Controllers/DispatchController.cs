using Microsoft.AspNetCore.Mvc;
using MiniMUZ.Api.MuzModels.Repository;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.Data_Manager;
using MiniMUZ.Api.Repository;

namespace MiniMUZ.Api.Controllers
{
    [Route("api/Dispatch")]
    [ApiController]
    public class DispatchController : Controller
    {
        private readonly IMuz<Dispatch, MuzModels.DTO.Dispatch.DispatchDTO> _dDispatch;

        public DispatchController(IMuz<Dispatch, MuzModels.DTO.Dispatch.DispatchDTO> muz)
        {
            _dDispatch = muz;

        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var Dispatch = _dDispatch.GetAll();
                return Ok(Dispatch);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
