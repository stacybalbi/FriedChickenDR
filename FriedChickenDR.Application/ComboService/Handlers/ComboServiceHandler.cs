using Agenda.Application.Generic.Handlers;
using AutoMapper;
using FriedChickenDR.Application.ComboService.Dtos;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.ComboService.Handlers
{
    public interface IComboHandler : IBaseCrudHandler<ComboServiceDto, Domain.Entities.ComboService>
    {
        new Task<ComboServiceDto> GetById(int id);
        new Task<ComboServiceDto> Update(ComboServiceDto dto);
        new Task<ComboServiceDto> Update(int id, ComboServiceDto dto);
        new Task<ComboServiceDto> Create(ComboServiceDto dto);
    }
    public class ComboServiceHandler : BaseCrudHandler<ComboServiceDto, Domain.Entities.ComboService>, IComboHandler
    {
        public ComboServiceHandler(IBaseCrudService<Domain.Entities.ComboService> crudService, IMapper mapper) : base(crudService, mapper)
        {
        }

        public new async Task<ComboServiceDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<ComboServiceDto> Update(ComboServiceDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<ComboServiceDto> Update(int id, ComboServiceDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<ComboServiceDto> Create(ComboServiceDto dto)
        {
            return await base.Create(dto);
        }
    }
}
