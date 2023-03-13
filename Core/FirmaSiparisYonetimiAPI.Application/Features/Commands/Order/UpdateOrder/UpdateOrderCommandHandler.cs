using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using o=FirmaSiparisYonetimiAPI.Domain.Entities;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Order.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        readonly IOrderReadRepository _orderReadRepository;
        readonly IOrderWriteRepository _orderWriteRepository;
        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            o.Order order = await _orderReadRepository.GetByIdAsync(request.ID);
            order.Company = request.Company;
            order.Product = request.Product;
            order.CustomerName = request.CustomerName;            
            await _orderWriteRepository.SaveAsync();
            return new();
        }
    }
}
