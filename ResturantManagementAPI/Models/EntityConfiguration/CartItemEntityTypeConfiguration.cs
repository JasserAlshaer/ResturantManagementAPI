using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class CartItemEntityTypeConfiguration : IEntityTypeConfiguration<CartItem>
    {
      

        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
    

         
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.Id).UseIdentityColumn(); 
            //builder.Property(x => x.Id).IsRequired(); 
            //builder.HasIndex(x => x.Id).IsUnique();

            builder.ToTable(x => x.HasCheckConstraint("Quantity-CH", "Qtn >= 0"));
            builder.Property(x=>x.Qtn).HasDefaultValue(0);
        
 
        }
    }
}
