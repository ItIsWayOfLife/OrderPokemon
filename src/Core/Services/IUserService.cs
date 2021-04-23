using Core.Entities;
using Core.Exceptions;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(User item)
        {
            if (String.IsNullOrWhiteSpace(item.Name))
            {
                throw new ValidationException("Не указано имя", string.Empty);
            }

            if (String.IsNullOrWhiteSpace(item.Email))
            {
                throw new ValidationException("Не указан email", string.Empty);
}

            if (String.IsNullOrWhiteSpace(item.PhoneNumber))
            {
                throw new ValidationException("Не указан номер телефона", string.Empty);
            }

            var user = Database.User.FindByEmail(item.Email);

            if (user != null)
            {
                if (item.Name != user.Name)
                {
                    throw new ValidationException($"Данный email уже занят пользователем по имени {user.Name}", string.Empty);
                }

                if (item.PhoneNumber != user.PhoneNumber)
                {
                    user.PhoneNumber = item.PhoneNumber;
                    Database.User.Update(user);
                }
            }
            else
            {
                Database.User.Create(item);
            }

            Database.Save();
        }
    }
}
