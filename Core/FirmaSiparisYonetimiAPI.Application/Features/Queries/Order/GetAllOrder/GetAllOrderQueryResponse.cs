using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Application.Features.Queries.Order.GetAllOrder
{
    public class GetAllOrderQueryResponse
    {
        public int TotalCount { get; set; }
        public object Orders { get; set; }
    }
}
