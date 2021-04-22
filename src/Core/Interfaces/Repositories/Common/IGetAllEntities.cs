using System.Collections.Generic;

namespace Core.Interfaces.Repositories.Common
{
    /// <summary>
    /// Get all entities models.
    /// </summary>
    /// <typeparam name="T">Entity model.</typeparam>
    public interface IGetAllEntities<T> where T : class
    {
        /// <summary>
        /// Get all models.
        /// </summary>
        /// <returns>IEnumerable models.</returns>
        IEnumerable<T> GetAll();
    }
}
