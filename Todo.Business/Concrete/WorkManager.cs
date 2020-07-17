using System;
using System.Collections.Generic;
using System.Text;
using Todo.Business.Interfaces;
using Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Repositories;
using Todo.Entities.Concrete;

namespace Todo.Business.Concrete
{
    class WorkManager : IWorkService
    {
        private readonly EfWorkRepository workRepository;

        public WorkManager()
        {
            workRepository = new EfWorkRepository();
        }
        public void Delete(Work table)
        {
            workRepository.Delete(table);
        }

        public List<Work> GetList()
        {
            return workRepository.GetList();
        }

        public Work GetObjectById(int id)
        {
            return workRepository.GetObjectById(id);
        }

        public void Save(Work table)
        {
            workRepository.Save(table);
        }

        public void Update(Work table)
        {
            workRepository.Save(table);
        }
    }
}
