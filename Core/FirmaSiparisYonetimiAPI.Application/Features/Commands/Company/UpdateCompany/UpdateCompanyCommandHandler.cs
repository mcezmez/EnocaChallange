using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using Microsoft.VisualBasic;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c=FirmaSiparisYonetimiAPI.Domain.Entities;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>
    {
        
        readonly ICompanyReadRepository _companyReadRepository;
        readonly ICompanyWriteRepository _companyWriteRepository;

        public UpdateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
        }

        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            c.Company company = await _companyReadRepository.GetByIdAsync(request.ID);
            company.CompanyName = request.CompanyName;
            company.Status = request.Status;
            company.OST = request.OST;
            company.OET = request.OET;
            await _companyWriteRepository.SaveAsync();
            return new();
            
        }
    }
}
