using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate).IsRequired(true);

            builder.ToTable(x => x.HasCheckConstraint("CH_OrderAddingDate", "OrderDate >= sysdatetime()"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);

            
        }
    }

}
