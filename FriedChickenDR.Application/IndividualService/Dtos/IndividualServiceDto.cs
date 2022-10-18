using FriedChickenDR.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Application.IndividualService.Dtos
{
    public class IndividualServiceDto : BaseDto
    {
        public string ProductName { get; set; }
        public int quality { get; set; }
    }
}
