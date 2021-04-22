using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _applicationContext;

        public UserRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Create(User item)
        {
            _applicationContext.Users.Add(item);
        }

        public IEnumerable<User> GetAll()
        {
            return _applicationContext.Users;
        }
    }
}
