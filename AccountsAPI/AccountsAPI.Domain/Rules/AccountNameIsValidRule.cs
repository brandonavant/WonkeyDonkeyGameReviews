using AccountsAPI.Domain.Constants;
using AccountsAPI.Domain.SeedWork;

namespace AccountsAPI.Domain.Rules 
{
    /// <summary>
    /// Rule that ensures that a given account name is valid.
    /// </summary>
    public class AccountNameIsValidRule : IBusinessRule 
    {
        public string ErrorMessage => ErrorMessages.AccountNameLengthError;
        private readonly string _firstName;
        private readonly string _lastName;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNameIsValidRule"/> class.
        /// </summary>
        /// <param name="firstName">The account holder's first name.</param>
        /// <param name="lastName">The account holder's last name.</param>
        public AccountNameIsValidRule (string firstName, string lastName) 
        {
            _lastName = lastName;
            _firstName = firstName;
        }

        /// <summary>
        /// Indicates when the <see cref="AccountNameIsValidRule"/> is broken for the given parameters.
        /// </summary>
        /// <returns>True if the given first name and/or last name aren't between 2 and 15 characters.</returns>
        public bool IsBroken () 
        {
            return (_firstName.Length < 2 || _firstName.Length > 15) || (_lastName.Length < 2 || _lastName.Length > 15);
        }
    }
}