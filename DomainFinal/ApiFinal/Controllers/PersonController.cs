using AppFinal;
using AppFinal.Contracts;
using DomainFinal.Interfaces;
using InfrastructureFinal;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinal.Controllers
{
    [ApiController]
    [Route("persons")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetList() 
        {
            var request = new GetPersonListRequest();
            var response = _mediator.Send(request);
            return Ok(response);

        }


    }
}
