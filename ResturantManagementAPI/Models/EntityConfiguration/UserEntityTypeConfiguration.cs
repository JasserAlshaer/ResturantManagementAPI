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
            //not null constaints 
            builder.Property(x=>x.Name).IsRequired(false);
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired(false);
            builder.Property(x => x.Password).IsRequired(false);
            builder.Property(x => x.ProfileImagePath).IsRequired(false);
            //set fixed size for string property 
            builder.Property(x => x.Name).HasMaxLength(128);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(16);
            //unique
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.HasIndex(x => x.Phone).IsUnique(true);
            //Check Constraint 
            builder.ToTable(x => x.HasCheckConstraint("Ch_User_name", "len(Name)>5"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_User_phone", "(len([Phone])=(10) AND ([Phone] like '079%' OR [Phone] like '078%' OR [Phone] like '077%'))"));
            builder.ToTable(x => x.HasCheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_User_password", "LEN(password) >= 8 AND LEN(password) <= 16"));
            //Default Constraint
            //builder.Property(x => x.UserType).HasDefaultValue("Client");
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
