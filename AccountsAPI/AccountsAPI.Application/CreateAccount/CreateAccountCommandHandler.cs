using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace AccountsAPI.Application.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, CreateAccountResponse>
    {
        public Task<CreateAccountResponse> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}