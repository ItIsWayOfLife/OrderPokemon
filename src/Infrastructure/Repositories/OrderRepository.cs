using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _applicationContext;

        public OrderRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Create(Order item)
        {
            _applicationContext.Orders.Add(item);
        }

        public IEnumerable<Order> GetAll()
        {
            return _applicationContext.Orders;
        }
    }
}
