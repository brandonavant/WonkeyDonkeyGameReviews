using System;

namespace AccountsAPI.Domain.Account
{
    public static class Events
    {
        public class AccountCreated
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public AccountRole Role { get; set; }
            public DateTime CreationDateTime { get; set; }                             
        }

        public class AccountNameChanged
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}