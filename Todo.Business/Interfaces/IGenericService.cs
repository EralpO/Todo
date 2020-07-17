using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Business.Interfaces
{
    interface IGenericService<T> where T : class
    {
        void Save(T table);
        void Delete(T table);

        void Update(T table);

        T GetObjectById(int id);
        List<T> GetList();
    }
}
