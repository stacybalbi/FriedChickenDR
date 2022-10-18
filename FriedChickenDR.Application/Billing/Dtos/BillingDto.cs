using FriedChickenDR.Application.Generic.Dto;
using FriedChickenDR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.Billing.Dtos
{
    public class BillingDto : BaseDto
    {
        public virtual ComboService Combo { get; set; }
        public int quantity { get; set; }
        public int total { get; set; }
    }
}
