using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class MealItemEntityTypeConfiguration : IEntityTypeConfiguration<MealItem>
    {
        public void Configure(EntityTypeBuilder<MealItem> builder)
        {
            builder.ToTable("MealItemss");

            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Id).UseIdentityColumn(); 
            
                       
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
           

        }
    }
}