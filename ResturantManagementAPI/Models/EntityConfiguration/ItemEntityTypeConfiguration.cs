using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemEntityTypeConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable(x => x.HasCheckConstraint("Quantity-CH", "Quantity > 10"));
            builder.ToTable(x => x.HasCheckConstraint("Price-CH", "Price > 0"));
            builder.Property(x=>x.Description).IsRequired(false);


        }
    }
}
