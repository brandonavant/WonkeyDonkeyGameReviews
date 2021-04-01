using System;
using AccountsAPI.AccountsAPI.Domain.SeedWork;
using AccountsAPI.Domain.Account;
using AccountsAPI.Domain.Rules;

namespace AccountsAPI.AccountsAPI.Domain.Account
{
    
    public class Account : AggregateRoot<Account, int>
    {
        private Account()
        {
            
        }

        public Account Create(IAccountUniquenessChecker uniquenessChecker)
        {
            CheckRule(new AccountIsUniqueRule(uniquenessChecker));

            return new Account();
        }
    }
}