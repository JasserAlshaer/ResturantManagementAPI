using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Email).IsRequired();
            builder.HasIndex(x=>x.Email).IsUnique();
            builder.Property(x=>x.Phone).IsRequired();  
            builder.Property(x=>x.Phone).IsUnicode();
            builder.ToTable(x => x.HasCheckConstraint("phone-CH", "Phone = 10"));// checking on this line 
            builder.Property(x=>x.UserType).IsRequired();

        }
    }
}
