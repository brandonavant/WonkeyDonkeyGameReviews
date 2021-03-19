using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace AccountsAPI.Application.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, CreateAccountResponse>
    {
        public async Task<CreateAccountResponse> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var createAccountRequest = request.Request;
            
            return new CreateAccountResponse { Id = Guid.NewGuid() };
        }
    }
}