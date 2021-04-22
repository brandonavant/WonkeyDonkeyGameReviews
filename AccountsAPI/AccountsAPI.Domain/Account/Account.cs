using System;
using AccountsAPI.AccountsAPI.Domain.SeedWork;
using AccountsAPI.Domain.Account;
using AccountsAPI.Domain.Rules;

namespace AccountsAPI.AccountsAPI.Domain.Account
{
    
    public class Account : AggregateRoot<Account, Guid>
    {
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }

        public string EmailAddress { get; private set; }

        public string DisplayName { get; private set; } 

        public string Password { get; private set;}
        
        public DateTime CreationDateTime { get; private set; }
    
        public DateTime LastModifiedDateTime { get; private set; }

        public AccountRole Role { get; private set; }                
                                            
        private Account(Guid id, string firstName, string lastName, AccountRole role)
        {
            ApplyChange(new Events.AccountCreated
            {
                Id
            })
        }

        public static Account Create(Guid id, string firstName, string lastName, AccountRole role)
        {
            CheckRule(new AccountNameIsValidRule(firstName, lastName));

            return new Account(firstName, lastName, role);
        }

        public void Update()
        {

        }
    }
}