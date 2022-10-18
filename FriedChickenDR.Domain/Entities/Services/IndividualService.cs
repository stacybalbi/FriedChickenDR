using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedChickenDR.Domain.Entities
{
    public class IndividualService : BaseEntity
    {
        public string ProductName { get; set; }
        public int quality { get; set; }
    }
}
