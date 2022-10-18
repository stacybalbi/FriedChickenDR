using Agenda.Application.Generic.Handlers;
using AutoMapper;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Application.IndividualService.Dtos;
using FriedChickenDR.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.IndividualService.Handlers
{
    public interface IIndividualHandler : IBaseCrudHandler<IndividualServiceDto, Domain.Entities.IndividualService>
    {
        new Task<IndividualServiceDto> GetById(int id);
        new Task<IndividualServiceDto> Update(IndividualServiceDto dto);
        new Task<IndividualServiceDto> Update(int id, IndividualServiceDto dto);
        new Task<IndividualServiceDto> Create(IndividualServiceDto dto);
    }
    public class IndividualServiceHandler : BaseCrudHandler<IndividualServiceDto, Domain.Entities.IndividualService>, IIndividualHandler
    {
        public IndividualServiceHandler(IBaseCrudService<Domain.Entities.IndividualService> crudService, IMapper mapper) : base(crudService, mapper)
        {

        }

        public new async Task<IndividualServiceDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<IndividualServiceDto> Update(IndividualServiceDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<IndividualServiceDto> Update(int id, IndividualServiceDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<IndividualServiceDto> Create(IndividualServiceDto dto)
        {
            return await base.Create(dto);
        }
    }
}
