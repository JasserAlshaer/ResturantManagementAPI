using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //forigen key 
            builder.HasOne<Cart>(x => x.Cart).WithOne(x => x.Order).HasForeignKey("Cart", "CartId");
            //check 
            builder.ToTable(x => x.HasCheckConstraint("Ch_NetPrice", "NetPrice=>0"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_TaxAmount", "TaxAmount=>0"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_DiscountAmount", "DiscountAmount=>0"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_TotalPrice", "TotalPrice=>0"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_phone", "(len([DelievryManPhone])=(10) AND ([DelievryManPhone] like '079%' OR [DelievryManPhone] like '078%' OR [Phone] like '077%'))"));

            //Default Constraint
            builder.Property(x => x.NetPrice).HasDefaultValue(0);
            builder.Property(x => x.TaxAmount).HasDefaultValue(0);
            builder.Property(x => x.DiscountAmount).HasDefaultValue(0);
            builder.Property(x => x.TotalPrice).HasDefaultValue(0);
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);
            //not Required
            builder.Property(x => x.Title).IsRequired(false);
            builder.Property(x => x.RecivieingMethod).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(false);









        }
    }

}
