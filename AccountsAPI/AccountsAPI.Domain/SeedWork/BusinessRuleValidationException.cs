using System;

namespace AccountsAPI.Domain.SeedWork
{
    public class BusinessRuleValidationException : Exception
    {
        public IBusinessRule BrokenRule { get; set; }

        public string Details { get; set; }

        public BusinessRuleValidationException(IBusinessRule brokenRule) : base(brokenRule.ErrorMessage)
        {
            BrokenRule = brokenRule;
            Details = brokenRule.ErrorMessage;
        }

        public override string ToString() => $"{BrokenRule.GetType().FullName}: {BrokenRule.ErrorMessage}";
    }
}