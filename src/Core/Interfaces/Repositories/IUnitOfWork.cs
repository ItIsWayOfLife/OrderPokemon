using System;

namespace Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Order repository. Working DB with entity Order.
        /// </summary>
        IOrderRepository Order { get; }

        /// <summary>
        /// User repository. Working DB with entity User.
        /// </summary>
        IUserRepository User { get; }

        /// <summary>
        /// Save data in DB.
        /// </summary>
        void Save();
    }
}
