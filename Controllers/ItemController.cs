using Microsoft.AspNetCore.Mvc;
using MiniMUZ.Api.MuzModels.Repository;
using MiniMUZ.Api.MuzModels;
using MiniMUZ.Api.Repository;

namespace MiniMUZ.Api.Controllers
{
    [Route("api/Item")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IMuz<Item, MuzModels.DTO.Item.ItemDTO> _dItem;

        public ItemController(IMuz<Item, MuzModels.DTO.Item.ItemDTO> muz)
        {
            _dItem = muz;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var item = _dItem.GetAll();
                return Json(item);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
