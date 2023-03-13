using FirmaSiparisYonetimiAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Domain.Entities
{
    public class Company : BaseEntity
    {

        public string CompanyName { get; set; }
        public bool Status { get; set; }
        public DateTime OST { get; set; }
        public DateTime OET { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
