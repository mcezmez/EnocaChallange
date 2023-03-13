using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryHadler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;

        public GetAllProductQueryHadler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _productReadRepository.GetAll(false).Count();
            var orders = _productReadRepository.GetAll(false).Select(p => new
            {
                p.ID,
                p.Company,
                p.ProductName,
                p.Stock,
                p.Price


            }).ToList();

            return new()
            {
                Products = orders,
                TotalCount = totalCount

            };
        }
    }
}
