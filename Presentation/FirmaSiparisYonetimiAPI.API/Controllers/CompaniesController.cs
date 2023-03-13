using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.CreateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.DeleteCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Commands.Company.UpdateCompany;
using FirmaSiparisYonetimiAPI.Application.Features.Queries.Company.GetAllCompany;
using FirmaSiparisYonetimiAPI.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparisYonetimiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        
        readonly IMediator _mediator;

        public CompaniesController(IMediator mediator = null, IProductWriteRepository productWriteRepository = null, ICompanyWriteRepository companyWriteRepository = null)
        {

            _mediator = mediator;
           
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCompanyQueryRequest getAllCompanyQueryRequest)
        {
            GetAllCompanyQueryResponse response = await _mediator.Send(getAllCompanyQueryRequest);
            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateCompanyCommandRequest createCompanyCommandRequest)
        {
           CreateCompanyCommandResponse response = await _mediator.Send(createCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);


        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCompanyCommandRequest updateCompanyCommandRequest)
        {
           UpdateCompanyCommandResponse response= await _mediator.Send(updateCompanyCommandRequest);
            return Ok();
          
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCompanyCommandRequest deleteCompanyCommandRequest)
        {
            DeleteCompanyCommandResponse response = await _mediator.Send(deleteCompanyCommandRequest);
            return Ok();
        }

         
    }

}
