using AutoMapper;
using FriedChickenDR.Application.ComboService.Dtos;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Domain.Entities;
using FriedChickenDR.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriedChickenDR.Controllers
{
    public class ComboController : Controller
    {
        private readonly IBaseCrudHandler<ComboServiceDto, ComboService> baseCrudHandler;
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;

        public ComboController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Pedido Combo")]

        public async Task<ActionResult<IEnumerable<ComboService>>> GetComboService()
        {
            return await _context.ComboService.ToListAsync();
        }

        [HttpPost("Ingresar Pedido Combo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PutComboService(int id, string name, string details, int price)
        {
            ComboServiceDto Datos = new ComboServiceDto
            {
                Id = id,
                Name = name,
                Details = details,
                price = price
            };

            _context.Entry(Datos).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("Editar Pedido Combo")]
        public async Task<ActionResult<IEnumerable<ComboServiceDto>>> PostComboService(int id, string name, string details, int price)
        {
            ComboServiceDto Datos = new ComboServiceDto
            {
                Id = id,
                Name = name,
                Details = details,
                price = price
            };
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComboService", new { id = Datos.Id }, Datos);
        }

        [HttpDelete("Eliminar Pedido Combo")]
        public async Task<IActionResult> DeleteCombolService(int id)
        {
            var service = await _context.ComboService.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            _context.ComboService.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
