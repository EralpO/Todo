using System.Collections.Generic;

namespace Todo.DataAccess.RepositoryInterfaces
{
    interface IGeneric<T> 
    {
        void Save(T user);
        void Delete(T user);

        void Update(T user);

        T GetObjectById(int id);
        List<T> GetList();
    }
}
