using Microsoft.AspNetCore.Mvc;

namespace FriedChickenDR.Controllers
{
    public class ComboController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
