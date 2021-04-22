
namespace Core.Interfaces.Repositories.Common
{
    /// <summary>
    /// Create new entity model.
    /// </summary>
    /// <typeparam name="T">Entity model.</typeparam>
    public interface ICreateEntity<T> where T : class
    {
        /// <summary>
        /// Create new model.
        /// </summary>
        /// <param name="item">Creatable model.</param>
        void Create(T item);
    }
}
