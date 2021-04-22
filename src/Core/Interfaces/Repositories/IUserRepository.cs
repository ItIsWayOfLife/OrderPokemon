using Core.Entities;
using Core.Interfaces.Repositories.Common;

namespace Core.Interfaces.Repositories
{
    /// <summary>
    /// Repository for working DB with entity User.
    /// </summary>
    public interface IUserRepository : ICreateEntity<User>, IGetAllEntities<User>
    {

    }
}
