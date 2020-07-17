using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Contexts;
using Todo.DataAccess.RepositoryInterfaces;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Repositories
{
   public class EfGenericRepository<T> : IGeneric<T> where T : class
    {
        public void Delete(T table)
        {
            using var context = new TodoContext();
            context.Set<T>().Remove(table);
            context.SaveChanges();
        }

        public T GetObjectById(int id)
        {
            using var context = new TodoContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new TodoContext();
            return context.Set<T>().ToList();
        }

        public void Save(T table)
        {
            using var context = new TodoContext();
            context.Set<T>().Add(table);
            context.SaveChanges();
        }

        public void Update(T table)
        {
            using var context = new TodoContext();
            context.Set<T>().Update(table);
            context.SaveChanges();
        }
    }
}
