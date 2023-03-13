using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQueryRequest, GetAllCompanyQueryResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;

        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }
        public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _companyReadRepository.GetAll(false).Count();
            var companies = _companyReadRepository.GetAll(false).Select(c => new
            {
                c.ID,
                c.CompanyName,
                c.Status,
                c.OST,
                c.OET


            }).ToList();

            return new()
            {
                Companies = companies,
                TotalCount = totalCount
            };

        }
    }
}
