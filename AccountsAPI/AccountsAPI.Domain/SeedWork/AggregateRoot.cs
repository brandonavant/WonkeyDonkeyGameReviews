using System;

namespace AccountsAPI.AccountsAPI.Domain.SeedWork
{
    /// <summary>
    /// Base class for Domain-layer aggregates.
    /// </summary>
    public abstract class AggregateRoot
    {
        /// <summary>
        /// Unique identifier for the Aggregate.
        /// </summary>
        public Guid Id { get; set; }
        
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
    }
}