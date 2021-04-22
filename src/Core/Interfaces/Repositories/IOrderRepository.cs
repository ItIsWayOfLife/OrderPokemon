using Core.Entities;
using Core.Interfaces.Repositories.Common;

namespace Core.Interfaces.Repositories
{
    /// <summary>
    /// Repository for working DB with entity Order.
    /// </summary>
    public interface IOrderRepository : ICreateEntity<Order>, IGetAllEntities<Order> 
    {

    }
}
