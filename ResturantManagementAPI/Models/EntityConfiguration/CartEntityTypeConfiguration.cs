using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class CartEntityTypeConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts"); // change table name 

            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x=>x.Id).UseIdentityColumn(); // applaying auto increment
            // not null constraint 
            //builder.Property(x=>x.Status).IsRequired(false); // marked as allow null
            builder.Property(x => x.Status).IsRequired(true);
            //unique constraint 
            //builder.HasIndex(x => x.Status).IsUnique();
            //check 
            builder.ToTable(x => x.HasCheckConstraint("CH_Cart_AddingDate", "CreatedDate >= sysdatetime()"));
            //default 
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x=>x.CreationDateTime).HasDefaultValue(DateTime.Now);
            //forigen key

        }
    }
}
