using MediatR;

namespace AccountsAPI.Application.CreateAccount
{
    public class CreateAccountCommand : IRequest<CreateAccountResponse>
    {
        public CreateAccountRequest Request { get; set; }
        public CreateAccountCommand(CreateAccountRequest request)
        {
            Request = request;
        }
    }
}