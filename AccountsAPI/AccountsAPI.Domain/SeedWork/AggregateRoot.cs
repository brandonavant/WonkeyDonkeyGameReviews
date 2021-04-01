using AccountsAPI.Domain.SeedWork;

namespace AccountsAPI.AccountsAPI.Domain.SeedWork
{
    /// <summary>
    /// Base class for Domain-layer aggregates.
    /// </summary>
    public abstract class AggregateRoot<T, TId>
        where T : class
    {
        /// <summary>
        /// Unique identifier for the Aggregate.
        /// </summary>
        public TId Id { get; set; }
        
        /// <summary>
        /// The version of the Aggregate in the EventStore.
        /// </summary>
        public int Version { get; private set; } = -1;

        /// <summary>
        /// Initializes a new instance of the AggregateRoot class.
        /// </summary>
        public AggregateRoot()
        {
            
        }
        
        /// <summary>
        /// Determines whether or not a given <see cref="IBusinessRule"/> is broken.
        /// </summary>
        /// <param name="rule">The <see cref="IBusinessRule"/> that is being validated.</param>
        protected static void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}