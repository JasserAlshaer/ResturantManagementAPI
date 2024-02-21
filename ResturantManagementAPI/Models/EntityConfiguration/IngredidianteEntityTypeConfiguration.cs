using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class IngredidianteEntityTypeConfiguration : IEntityTypeConfiguration<Ingredidiante>
    {
        public void Configure(EntityTypeBuilder<Ingredidiante> builder)
        {
            builder.ToTable("Ingredidiantes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.PricePerUnit).IsRequired(true);
            builder.Property(x => x.IngredientName).IsRequired(true);


            builder.HasIndex(x => x.IngredientName).IsUnique();

            builder.ToTable(x => x.HasCheckConstraint("CH_IngredidianteCheckPrice", "PricePerUnit >=0"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.HasMany(i => i.ItemIngredidiantes)
                .WithOne(i => i.Ingredidiante)
                .HasForeignKey("IngredidianteId");

        }
    }
}
