using FriedChickenDR.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace FriedChickenDR.Controllers
{
    public class BillingController : Controller
    {
        private readonly ApplicationDBContext _context;

        public BillingController(ApplicationDBContext context)
        {
            _context = context;
        }

    }
}
