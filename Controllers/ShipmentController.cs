using Microsoft.AspNetCore.Mvc;

namespace MiniMUZ.Api.Controllers
{
    public class ShipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
