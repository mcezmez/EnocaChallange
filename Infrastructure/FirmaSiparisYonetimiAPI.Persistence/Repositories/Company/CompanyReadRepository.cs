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
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(FirmaServisYonetimiAPIDbContext context) : base(context)
        {
        }
    }
}
