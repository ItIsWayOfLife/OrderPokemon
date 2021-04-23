using Core.Entities;

namespace Core.Interfaces.Services
{
    /// <summary>
    /// Service for working with entity User.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="item">Creatable user.</param>
        void Create(User item);
    }
}
