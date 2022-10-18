using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Domain.Entities
{
    public class ComboService : BaseEntity
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal price { get; set; }
        
    }
}
