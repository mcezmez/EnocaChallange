using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommandRequest,DeleteCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;     


        public DeleteCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            
        }

        public async Task<DeleteCompanyCommandResponse> Handle(DeleteCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.RemoveAsync(request.ID);
            await _companyWriteRepository.SaveAsync();
            return new();

        }
    }
}
