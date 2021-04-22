using Core.Entities;
using Core.Interfaces.Repositories.Common;

namespace Core.Interfaces.Repositories
{
    public interface IOrderRepository : ICreateEntity<Order>, IGetAllEntities<Order> 
    {

    }
}
