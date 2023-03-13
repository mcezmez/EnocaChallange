using FirmaSiparisYonetimiAPI.Application.Repositories;
using FirmaSiparisYonetimiAPI.Domain.Entities;
using FirmaSiparisYonetimiAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(FirmaServisYonetimiAPIDbContext context) : base(context)
        {
        }
    }
}
