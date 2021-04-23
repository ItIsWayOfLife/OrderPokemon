using Core.DTOs;
using System.Collections.Generic;

namespace Core.Interfaces.Services
{
    /// <summary>
    /// Service for working with entity Order.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="userEmail">User email.</param>
        void Create(string userEmail);

        /// <summary>
        /// Get all models.
        /// </summary>
        /// <returns>IEnumerable models.</returns>
        IEnumerable<OrderDTO> GetAll();
    }
}
