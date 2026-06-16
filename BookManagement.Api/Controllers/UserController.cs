using BookManagement.Application.UseCases.User.Commands;
using BookManagement.Application.UseCases.User.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace BookManagemant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand request, CancellationToken ct)
        {
            await _mediator.Send(request, ct);
            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetUserById([FromQuery] Guid id, CancellationToken ct)
        {
            var response = await _mediator.Send(new GetUserById.GetUserByIdQuery(id), ct);
            return Ok(response);
        }
    }
}
