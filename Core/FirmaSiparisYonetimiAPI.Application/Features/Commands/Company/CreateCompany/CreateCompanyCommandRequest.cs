using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandRequest : IRequest<CreateCompanyCommandResponse>
    {
        public string CompanyName { get; set; }
        public bool Status { get; set; }
        public DateTime OST { get; set; }
        public DateTime OET { get; set; }

    }
}
