using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest<UpdateProductCommandResponse>
    {
        public string ID { get; set; }
        public FirmaSiparisYonetimiAPI.Domain.Entities.Company Company { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
