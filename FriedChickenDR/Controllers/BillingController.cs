using AutoMapper;
using FriedChickenDR.Application.Billing.Dtos;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Application.IndividualService.Dtos;
using FriedChickenDR.Domain.Entities;
using FriedChickenDR.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriedChickenDR.Controllers
{
    public class BillingController : Controller
    {
        private readonly IBaseCrudHandler<BillingDto, Billing> baseCrudHandler;
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;

        public BillingController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Factura")]

        public async Task<ActionResult<IEnumerable<Billing>>> GetBilling()
        {
            return await _context.Billing.ToListAsync();
        }

        [HttpPost("Ingresar Factura")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PutBilling(int id, ComboService combo, int quantity, int total)
        {
            BillingDto Datos = new BillingDto
            {
                Id = id,
                Combo = combo,
                quantity = quantity,
                total = total
            };

            _context.Entry(Datos).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("Editar Factura")]
        public async Task<ActionResult<IEnumerable<IndividualServiceDto>>> PostBilling(int id, ComboService combo, int quantity, int total)
        {
            BillingDto Datos = new BillingDto
            {
                Id = id,
                Combo = combo,
                quantity = quantity,
                total = total
            };
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBilling", new { id = Datos.Id }, Datos);
        }

        [HttpDelete("Eliminar Factura")]
        public async Task<IActionResult> DeleteBilling(int id)
        {
            var billing = await _context.Billing.FindAsync(id);
            if (billing == null)
            {
                return NotFound();
            }

            _context.Billing.Remove(billing);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
