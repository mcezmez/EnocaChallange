using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.DeleteCompany
{
    public class DeleteCompanyCommandRequest:IRequest<DeleteCompanyCommandResponse>
    {
        public string ID { get; set; }
    }
}
