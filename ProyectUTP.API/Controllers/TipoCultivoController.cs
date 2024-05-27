using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.DeleteTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.UpdateTipoCultivo;
using ProyectUTP.Application.Features.Queries.GetTipoCultivo;

namespace ProyectUTP.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TipoCultivoController:ControllerBase
    {
        private readonly IMediator _mediator;

        public TipoCultivoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddTipoCultivo")]

        //[Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<CreateTipoCultivoResponse>> AddTipoCultivo([FromBody] CreateTipoCultivoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("GetTipoCultivo")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<AllResponseMessage<GetTipoCultivoResult>>> GetTipoCultivo([FromQuery] GetTipoCultivoQuery command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("DeleteTipoCultivo")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<DeleteTipoCultivoResult>> DeleteTipoCultivo([FromBody] DeleteTipoCultivoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateTipoCultivo")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<UpdateTipoCultivoResult>> UpdateTipoCultivo([FromBody] UpdateTipoCultivoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
