using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.MuzModels.DTO.Shipment;

namespace MiniMUZ.Api.Controllers
{
    public class Usere
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    [Route("api/Identity")]
    [ApiController]
    public class UserIdnController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserIdnController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usere model)
        {


            try
            {
                var aspnetuser = new IdentityUser 
                {
                    Email = model.Email,
                    UserName = model.Email
                };
                var result = await _userManager.CreateAsync(aspnetuser, model.Password);
                if(result.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            //return Ok(vehicle);
        }

    }
}
