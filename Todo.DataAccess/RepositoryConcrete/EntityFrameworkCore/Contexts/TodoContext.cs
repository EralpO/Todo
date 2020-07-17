using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Mapping;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Contexts
{
    public class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VMENBD0\\SQLEXPRESS; database=TodoUdemy; user id=eralp; password=258456;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WorkMap());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
