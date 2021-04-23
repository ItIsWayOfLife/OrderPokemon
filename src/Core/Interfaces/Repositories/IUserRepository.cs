using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces.Repositories
{
    /// <summary>
    /// Repository for working DB with entity User.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="item">Creatable model.</param>
        void Create(User item);

        /// <summary>
        /// Get all models.
        /// </summary>
        /// <returns>IEnumerable models.</returns>
        IEnumerable<User> GetAll();

        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="item">Creatable model.</param>
        public User Get(int id);

        /// <summary>
        /// Find model by email.
        /// </summary>
        /// <param name="email">User email.</param>
        /// <returns>Entity model.</returns>
        User FindByEmail(string email);

        /// <summary>
        /// Update model.
        /// </summary>
        /// <param name="item">Update model.</param>
        void Update(User item);
    }
}
