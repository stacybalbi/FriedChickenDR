using Agenda.Application.Generic.Handlers;
using AutoMapper;
using FriedChickenDR.Application.Billing.Dtos;
using FriedChickenDR.Application.Generic.Interfaces;
using FriedChickenDR.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.Billing.Handlers
{
    public interface IBillingHandler : IBaseCrudHandler<BillingDto, Domain.Entities.Billing>
    {
        new Task<BillingDto> GetById(int id);
        new Task<BillingDto> Update(BillingDto dto);
        new Task<BillingDto> Update(int id, BillingDto dto);
        new Task<BillingDto> Create(BillingDto dto);
    }
    public class BillingHandler : BaseCrudHandler<BillingDto, Domain.Entities.Billing>, IBillingHandler
    {
        public BillingHandler(IBaseCrudService<Domain.Entities.Billing> crudService, IMapper mapper) : base(crudService, mapper)
        {

        }

        public new async Task<BillingDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<BillingDto> Update(BillingDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<BillingDto> Update(int id, BillingDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<BillingDto> Create(BillingDto dto)
        {
            return await base.Create(dto);
        }

    }
}
