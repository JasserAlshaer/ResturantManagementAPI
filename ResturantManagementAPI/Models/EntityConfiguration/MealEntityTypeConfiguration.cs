using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class MealEntityTypeConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meals");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(false);



            builder.HasIndex(x => x.Name).IsUnique();

            builder.ToTable(x => x.HasCheckConstraint("CH_MealPriceNotZero", "Price > 0"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        }
    }
}
