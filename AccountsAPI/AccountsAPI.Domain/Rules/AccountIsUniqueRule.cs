using AccountsAPI.Domain.Account;
using AccountsAPI.Domain.SeedWork;

namespace AccountsAPI.Domain.Rules
{
    public class AccountIsUniqueRule : IBusinessRule
    {
        public string ErrorMessage => "The account name that you have chosen is taken.";
        private readonly IAccountUniquenessChecker _accountUniquenessChecker;

        public AccountIsUniqueRule(IAccountUniquenessChecker accountUniquenessChecker)
        {
            _accountUniquenessChecker = accountUniquenessChecker;
        }

        /// <summary>
        /// Determines whether or not a given account name is taken.
        /// </summary>
        /// <returns></returns>
        public bool IsBroken()
        {
            return !_accountUniquenessChecker.IsUnique();
        }
    }
}