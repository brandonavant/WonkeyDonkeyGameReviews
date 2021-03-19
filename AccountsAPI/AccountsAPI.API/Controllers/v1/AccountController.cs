using System;
using System.Threading.Tasks;
using AccountsAPI.Application.CreateAccount;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountsAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAccount(CreateAccountRequest request)
        {
            try
            {
                var result = await _mediator.Send(new CreateAccountCommand(request));

                return Ok(result);
            }
            catch (Exception ex)
            {
                // TODO bavant: Logging

                return new StatusCodeResult(500);
            }            
        }
    }
}
