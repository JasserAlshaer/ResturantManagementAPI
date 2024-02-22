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

            builder.Property(n => n.Name)
                .HasMaxLength(50);

            builder.Property(d => d.Description)
                .IsRequired(false)
                .HasMaxLength(250);

            builder.Property(i => i.ImagePath)
                .IsRequired(false);

            builder.Property(p => p.Price)
                .HasDefaultValue(0);

            builder.ToTable(m =>
            {
                m.HasCheckConstraint("CH_Price", "Price > 0");
                m.HasCheckConstraint("CH_Name", "LEN(Name)>4");
            });

        }
    }
}
