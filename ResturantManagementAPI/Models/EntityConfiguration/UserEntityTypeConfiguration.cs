using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.UserType).IsRequired(true);

            builder.HasIndex(x => x.Email).IsUnique();

            builder.ToTable(x => x.HasCheckConstraint("CH_EmailValidation", "[Email] like '%@gmail.com'"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.HasMany(c => c.Carts)
                .WithOne(u => u.User)
                .HasForeignKey("UserId");
        }
    }
}
