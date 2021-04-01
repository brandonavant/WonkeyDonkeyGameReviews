namespace AccountsAPI.Domain.SeedWork
{
    public interface IBusinessRule
    {
        /// <summary>
        /// Determines whether or not a business rule is broken.
        /// </summary>
        /// <returns>True when the rule is broken.</returns>
         bool IsBroken();

        /// <summary>
        /// The error message provided when the rule is broken.
        /// </summary>
        /// <value></value>
        string ErrorMessage { get; }
    }
}