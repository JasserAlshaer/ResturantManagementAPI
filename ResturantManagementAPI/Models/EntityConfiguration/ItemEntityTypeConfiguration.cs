using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemEntityTypeConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items"); // change table name 

            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x => x.Id).UseIdentityColumn(); // applaying auto increment
            //  null constraint (Optional)
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.ImagePath).IsRequired(false);
            //set fixed size for string property 
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(150);

            //check 
            builder.ToTable(x => x.HasCheckConstraint("CH_Quantity", "LEN(Quantity) >0 "));
            builder.ToTable(x => x.HasCheckConstraint("CH_price", "LEN(Price) >0 "));
            builder.ToTable(x => x.HasCheckConstraint("CH_Name", "LEN(Quantity) >3 "));
            builder.ToTable(x => x.HasCheckConstraint("CH_Description", "LEN(Description) >0 "));

            //default 
            builder.Property(x => x.Quantity).HasDefaultValue(1);
            builder.Property(x => x.Price).HasDefaultValue(1);
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
