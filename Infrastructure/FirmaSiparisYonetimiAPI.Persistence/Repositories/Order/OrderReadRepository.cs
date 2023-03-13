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
    public class OrderReadRepository:ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(FirmaServisYonetimiAPIDbContext context) : base(context)
        {
        }
    }
}
