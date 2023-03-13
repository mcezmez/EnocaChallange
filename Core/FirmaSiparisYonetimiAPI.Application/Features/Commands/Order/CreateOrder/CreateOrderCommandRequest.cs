using FirmaSiparisYonetimiAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandRequest:IRequest<CreateOrderCommandResponse>
    {
        public FirmaSiparisYonetimiAPI.Domain.Entities.Company Company { get; set; }
        public FirmaSiparisYonetimiAPI.Domain.Entities.Product Product { get; set; }
        public string CustomerName { get; set; }
    }
}
