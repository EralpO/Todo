using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Entities.Concrete;

namespace Todo.DataAccess.RepositoryConcrete.EntityFrameworkCore.Mapping
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.UserId);
            builder.Property(I => I.UserId).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(40).IsRequired();
            builder.Property(I => I.Surname).HasMaxLength(40).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(40).IsRequired();
            builder.Property(I => I.Phone).HasMaxLength(40);

            builder.HasMany(I => I.Works).WithOne(I => I.User).HasForeignKey(I => I.UserId);
        }
    }
}
