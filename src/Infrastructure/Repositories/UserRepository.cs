using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        public User FindByEmail(string email)
        {
            return _applicationContext.Users.Where(p=>p.Email == email).FirstOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            return _applicationContext.Users;
        }

        public void Update(User item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public User Get(int id)
        {
            return _applicationContext.Users.Find(id);
        }
    }
}
