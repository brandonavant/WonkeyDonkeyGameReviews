using System.Collections.Generic;
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
        /// A list of changes to be sent to the event store.
        /// </summary>
        private readonly List<object> _changes;
        
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

        protected abstract void When(object @event);

        /// <summary>
        /// 
        /// </summary>
        protected void ApplyChange(object @event)
        {
            When(@event);
            _changes.Add(@event);
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