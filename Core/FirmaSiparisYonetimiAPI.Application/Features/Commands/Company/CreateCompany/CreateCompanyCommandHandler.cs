using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.CreateCompany;
using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CreateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.AddAsync(new()
            {
                CompanyName = request.CompanyName,
                Status = request.Status,
                OST = request.OST,
                OET=request.OET

            });
            await _companyWriteRepository.SaveAsync();

            return new();
;            
        }
    }
}
