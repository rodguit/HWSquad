//using Microsoft.AspNetCore.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Gtwave.App.Api.Contracts;
using Gtwave.App.Application.Authentication.Login;
using Gtwave.App.Application.Authentication.Register;

namespace Gtwave.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private readonly IMediator _mediator; 
        private readonly IMapper _mapper;
        public OAuthController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);
            
            var authResult = await _mediator.Send(command);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticatiAppesponse>(authResult)), _
                => Problem(statusCode: StatusCodes.Status409Conflict, title: "Usuário já cadastrado"));

            //var response = _mapper.Map<AuthenticatiAppesponse>(authResult);

            //return Ok(response);
        }
         
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginRequest request)
        {
            var query = _mapper.Map<LoginQuery>(request);

            var authResult =await _mediator.Send(query);

            var response = _mapper.Map<AuthenticatiAppesponse>(authResult);

            return Ok(response);
        }
    }
}
