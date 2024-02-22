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
            builder.Property(x => x.PromoCode).HasDefaultValue(0.2);
            builder.Property(x=>x.PaymentMethod).IsRequired();
            builder.ToTable(x => x.HasCheckConstraint("OrderDate-ch", "OrderDate >= sysdatetime()"));


        }
    }

}
