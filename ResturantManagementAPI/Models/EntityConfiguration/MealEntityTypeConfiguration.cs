using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class MealEntityTypeConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.ItemId).IsRequired();
            builder.HasIndex(x=>x.ItemId).IsUnique();
            builder.Property(x=> x.Name).IsRequired();  
            builder.Property(x=>x.Description).IsRequired(false);
            builder.ToTable(x => x.HasCheckConstraint("Price-CH", "Price > 0"));
            builder.Property(x=>x.Image).IsRequired();

        }
    }
}
