using AccountsAPI.AccountsAPI.Domain.Account;
using AccountsAPI.Domain.Constants;
using AccountsAPI.Domain.Rules;
using AccountsAPI.Domain.SeedWork;
using Xunit;

namespace AccountsAPI.Tests.UnitTests.Domain
{
    public class AccountUnitTests
    {
        [Fact]
        public void 

        [Fact]
        public void Account_CreateNewAccountWithInvalidFirstName_ThrowsBusinessRuleException()
        {
            var firstName = string.Empty;
            var lastName = "Doe";

            var exception = Assert.Throws<BusinessRuleValidationException>(() => Account.Create(firstName, lastName));
            var brokenRule = exception.BrokenRule;

            Assert.Equal(typeof(AccountNameIsValidRule), brokenRule.GetType());
            Assert.Equal(ErrorMessages.AccountNameLengthError, exception.Details);
        }
    }
}