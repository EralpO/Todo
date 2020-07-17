using System.Collections.Generic;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Repositories
{
    interface IUser
    {
        void SaveUser(User user);
        void DeleteUser(User user);

        void UpdateUser(User user);

        User GetUserById(int id);
        List<User> GetUserList();
    }
}
