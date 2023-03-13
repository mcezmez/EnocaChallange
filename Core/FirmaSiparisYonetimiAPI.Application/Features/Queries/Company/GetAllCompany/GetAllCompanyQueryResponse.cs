using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryResponse
    {
        public int TotalCount { get; set; }
        public object Companies { get; set; }
    }
}
