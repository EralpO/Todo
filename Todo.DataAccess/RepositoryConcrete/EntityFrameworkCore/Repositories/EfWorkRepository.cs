using System;
using System.Collections.Generic;
using Todo.DataAccess.RepositoryInterfaces;
using Todo.Entities.Concrete;
using System.Linq;
using Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Contexts;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Repositories
{
    public class EfWorkRepository : EfGenericRepository<Work>
    {

       
    }
}
