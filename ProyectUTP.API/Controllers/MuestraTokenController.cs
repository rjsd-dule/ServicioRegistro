using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProyectUTP.Application.Features.Commands.Token;
using ProyectUTP.Application.Features.Queries.TokenQuery;

namespace ProyectUTP.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MuestraTokenController:ControllerBase
    {
        private readonly IMediator _mediator;

        public MuestraTokenController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetToken")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<GetTokenResult>> GetToken([FromQuery] TokenQuery command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateToken")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<TokenResult>> UpdateToken([FromBody] TokenCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
