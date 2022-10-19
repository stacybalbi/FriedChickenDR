using FriedChickenDR.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace FriedChickenDR.Controllers
{
    public class IndividualController : Controller
    {
        private readonly ApplicationDBContext _context;

        public IndividualController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("Ingresar Pedido Individual")]

        public IActionResult GetIndividualService()
        {
            return View();
        }
    }
}
