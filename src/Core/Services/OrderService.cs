using Core.DTOs;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Core.Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(string UserEmail)
        {
            Order order = new Order();

            int? userId = Database.User.FindByEmail(UserEmail).Id;

            order.UserId = userId ?? throw new ValidationException("Такой пользователь не найден", string.Empty);
            order.DateTimeOrder = DateTime.Now;

            Database.Order.Create(order);
            Database.Save();
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var orders = Database.Order.GetAll().ToList();
            var users = Database.User.GetAll().ToList();

            var orderDTOs = new List<OrderDTO>();

            foreach (var order in orders)
            {
                var user = users.Where(p=>p.Id == order.UserId).FirstOrDefault();

                orderDTOs.Add(new OrderDTO()
                {
                    DateTimeOrder = order.DateTimeOrder,
                    UserName = user.Name,
                    OrderQuantity = Database.Order.GetAll().OrderBy(p => p.DateTimeOrder)
                        .Where(p => p.UserId == user.Id && p.DateTimeOrder <= order.DateTimeOrder).Count()
                });
            }

            return orderDTOs;
        }
    }
}
