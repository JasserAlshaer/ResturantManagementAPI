using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemEntityTypeConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Quantity).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true);


            builder.ToTable(x => x.HasCheckConstraint("CH_ItemQtyNotZero", "Quantity > 0"));
            builder.ToTable(x => x.HasCheckConstraint("CH_ItemPriceNotZero", "Price > 0"));
            
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        }
    }
}
