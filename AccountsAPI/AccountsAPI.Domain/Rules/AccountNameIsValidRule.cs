using AccountsAPI.Domain.Constants;
using AccountsAPI.Domain.SeedWork;

namespace AccountsAPI.Domain.Rules {
    public class AccountNameIsValidRule : IBusinessRule 
    {
        public string ErrorMessage => ErrorMessages.AccountNameLengthError;
        private readonly string _firstName;
        private readonly string _lastName;

        public AccountNameIsValidRule (string firstName, string lastName) 
        {
            _lastName = lastName;
            _firstName = firstName;
        }

        public bool IsBroken () 
        {
            return (_firstName.Length < 2 || _firstName.Length > 15) || (_lastName.Length < 2 || _lastName.Length > 15);
        }
    }
}