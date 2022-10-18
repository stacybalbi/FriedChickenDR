using FriedChickenDR.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.ComboService.Dtos
{
    public class ComboServiceDto : BaseDto
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal price { get; set; }
    }
}
