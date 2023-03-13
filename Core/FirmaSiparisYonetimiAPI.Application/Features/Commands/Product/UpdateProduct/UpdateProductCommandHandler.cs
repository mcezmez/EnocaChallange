﻿using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p=FirmaSiparisYonetimiAPI.Domain.Entities;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IProductWriteRepository _productWriteRepository;

        public UpdateProductCommandHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }


        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            p.Product product = await _productReadRepository.GetByIdAsync(request.ID);
            product.Company = request.Company;
            product.ProductName = request.ProductName;
            product.Stock = request.Stock;
            product.Price = request.Price;
            await _productWriteRepository.SaveAsync();
            return new();

        }
    }
}
