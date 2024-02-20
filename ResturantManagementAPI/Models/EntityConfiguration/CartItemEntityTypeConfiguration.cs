using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class CartItemEntityTypeConfiguration : IEntityTypeConfiguration<CartItem>
    {


        public void Configure(EntityTypeBuilder<CartItem> builder)
        {

            builder.ToTable("CartItems");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
           
            builder.Property(x => x.Qtn).IsRequired(true);
            
             
            builder.ToTable(x => x.HasCheckConstraint("CH_CartItem_QtnNotZero", "Qtn > 0"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        }
    }
}
