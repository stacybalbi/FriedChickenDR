using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Domain.Entities
{
    public class Billing : BaseEntity
    {
        public virtual ComboService Combo { get; set; }
        public int quantity { get; set; }
        public int total { get; set; }

    }
}
