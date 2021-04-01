using System;
using AccountsAPI.AccountsAPI.Domain.SeedWork;
using AccountsAPI.Domain.Account;
using AccountsAPI.Domain.Rules;

namespace AccountsAPI.AccountsAPI.Domain.Account
{
    
    public class Account : AggregateRoot<Account, Guid>
    {
        // TODO: Add props
        
        private Account()
        {
            
        }

        public Account Create(IAccountUniquenessChecker uniquenessChecker)
        {
            // TODO: Talk about (as a group) what uniqueness is and write unit tests to support.
            CheckRule(new AccountIsUniqueRule(uniquenessChecker));

            return new Account();
        }
    }
}