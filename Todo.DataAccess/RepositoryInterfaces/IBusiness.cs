using System.Collections.Generic;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.RepositoryInterfaces
{
    interface IBusiness
    {
        void SaveWork(Work business);
        void DeleteWork(Work business);

        void UpdateWork(Work business);

        Work GetWorkById(int id);
        List<Work> GetWorkList();
    }
}
