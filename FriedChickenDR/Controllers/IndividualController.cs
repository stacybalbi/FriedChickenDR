using AutoMapper;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Application.IndividualService.Dtos;
using FriedChickenDR.Domain.Entities;
using FriedChickenDR.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriedChickenDR.Controllers
{
    public class IndividualController : Controller
    {

        private readonly IBaseCrudHandler<IndividualServiceDto, IndividualService> baseCrudHandler;
        private readonly IMapper _mapper;
        private readonly ApplicationDBContext _context;

        public IndividualController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Pedido Individual")]

        public async Task<ActionResult<IEnumerable<IndividualService>>> GetIndividualService()
        {
            return await _context.IndividualServiceDto.ToListAsync();
        }

        [HttpPost("Ingresar Pedido Individual")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PutIndividualService(int id, string productName, int quality)
        {
            IndividualServiceDto Datos = new IndividualServiceDto
            {
                Id = id,
                ProductName = productName,
                quality = quality
            };

            _context.Entry(Datos).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            
            return Ok();
        }

        [HttpPost("Editar Pedido Individual")]
        public async Task<ActionResult<IEnumerable<IndividualServiceDto>>> PostIndividualService(int id, string productName, int quality)
        {
            IndividualServiceDto Datos = new IndividualServiceDto
            {
                Id = id,
                ProductName = productName,
                quality = quality
            };
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIndividualService", new { id = Datos.Id }, Datos);
        }

        [HttpDelete("Eliminar Pedido Individual")]
        public async Task<IActionResult> DeleteIndividualService(int id)
        {
            var service = await _context.IndividualServiceDto.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            _context.IndividualServiceDto.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
