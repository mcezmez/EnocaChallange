using FirmaSiparisYonetimiAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Company Company { get; set; }
        public Product Product { get; set; }
        public string CustomerName { get; set; }

    }
}
