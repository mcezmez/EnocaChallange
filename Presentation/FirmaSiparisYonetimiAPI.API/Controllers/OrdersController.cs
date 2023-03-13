using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.CreateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.DeleteCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.UpdateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Order.CreateOrder;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Order.DeleteOrder;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Order.UpdateOrder;
using FirmaSiparisYonetimiAPI.Application.Features.Queries.Company.GetAllCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Queries.Order.GetAllOrder;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparisYonetimiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllOrderQueryRequest getAllCompanyQueryRequest)
        {
            GetAllOrderQueryResponse response = await _mediator.Send(getAllCompanyQueryRequest);
            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateOrderCommandRequest createOrderCommandRequest)
        {
            CreateOrderCommandResponse response = await _mediator.Send(createOrderCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);


        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateOrderCommandRequest updateOrderCommandRequest)
        {
            UpdateOrderCommandResponse response = await _mediator.Send(updateOrderCommandRequest);
            return Ok();

        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderCommandRequest deleteOrderCommandRequest)
        {
            DeleteOrderCommandResponse response = await _mediator.Send(deleteOrderCommandRequest);
            return Ok();
        }
    }
}
