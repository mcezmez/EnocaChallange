using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Queries.Order.GetAllOrder
{
    public class GetAllOrderQueryHadler:IRequestHandler<GetAllOrderQueryRequest,GetAllOrderQueryResponse>
    {
        readonly IOrderReadRepository _orderReadRepository;

        public GetAllOrderQueryHadler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GetAllOrderQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {

            var totalCount = _orderReadRepository.GetAll(false).Count();
            var orders = _orderReadRepository.GetAll(false).Select(o => new
            {
                o.ID,
                o.Company,
                o.Product,
                o.CustomerName,
                o.CreateDate


            }).ToList();

            return new()
            {
                Orders = orders,
                TotalCount = totalCount        
            
            };

        }
    }
}
