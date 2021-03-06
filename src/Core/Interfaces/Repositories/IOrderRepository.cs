using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces.Repositories
{
    /// <summary>
    /// Repository for working DB with entity Order.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="item">Creatable model.</param>
        void Create(Order item);

        /// <summary>
        /// Get all models.
        /// </summary>
        /// <returns>IEnumerable models.</returns>
        IEnumerable<Order> GetAll();
    }
}
