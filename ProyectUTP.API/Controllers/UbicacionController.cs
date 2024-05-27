using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Features.Commands.Ubicacion.CreateUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.DeleteUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion;
using ProyectUTP.Application.Features.Queries.Ubicacion;

namespace ProyectUTP.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UbicacionController: ControllerBase
    {
        private readonly IMediator _mediator;

        public UbicacionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddUbicacion")]

        //[Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<CreateUbicacionResult>> AddUbicacion([FromBody] CreateUbicacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("GetUbicacion")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<AllResponseMessage<GetUbicacionResult>>> GetUbicacion([FromQuery] GetUbicacionQuery command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("DeleteUbicacion")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<DeleteUbicacionResult>> DeleteUbicacion([FromBody] DeleteUbicacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateUbicacion")]

        // [Authorize(Roles = "Administrator")] 
        public async Task<ActionResult<UpdateUbicacionResult>> UpdateUbicacion([FromBody] UpdateUbicacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
