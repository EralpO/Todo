using System.Collections.Generic;
using Todo.Business.Interfaces;
using Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Repositories;
using Todo.Entities.Concrete;

namespace Todo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository userRepository;

        public UserManager()
        {
            userRepository = new EfUserRepository();
        }
        public void Delete(User table)
        {
            userRepository.Delete(table);
        }

        public List<User> GetList()
        {
            return userRepository.GetList();
        }

        public User GetObjectById(int id)
        {
            return userRepository.GetObjectById(id);
        }

        public void Save(User table)
        {
            userRepository.Save(table);
        }

        public void Update(User table)
        {
            userRepository.Save(table);
        }
    }
}
