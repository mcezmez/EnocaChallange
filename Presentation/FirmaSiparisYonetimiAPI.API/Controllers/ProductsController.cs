using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.CreateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.DeleteCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.UpdateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Product.CreateProduct;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Product.DeleteProduct;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Product.UpdateProduct;
using FirmaSiparisYonetimiAPI.Application.Features.Queries.Company.GetAllCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Queries.Product.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparisYonetimiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);


        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();

        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest deleteProductCommandRequest)
        {
            DeleteProductCommandResponse response = await _mediator.Send(deleteProductCommandRequest);
            return Ok();
        }
    }
}
