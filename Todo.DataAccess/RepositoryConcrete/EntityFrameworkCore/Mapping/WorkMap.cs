using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Mapping
{
    class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(40).IsRequired();
            builder.Property(I => I.Description).HasColumnType("ntext");
          
        }
    }
}
