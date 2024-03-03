using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class IngratiateEntityTypeConfiguration : IEntityTypeConfiguration<Ingratiate>
    {
        public void Configure(EntityTypeBuilder<Ingratiate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.PricePerUnit).IsRequired(true);
            builder.Property(x => x.PricePerUnit).HasDefaultValue(0);
            builder.ToTable(x => x.HasCheckConstraint("CH_Ingratiate_PricePerUnit", "(PricePerUnit) >= 0"));


            builder.Property(x => x.IngredientName).IsRequired(true);
            builder.HasIndex(x => x.IngredientName).IsUnique(true);
            builder.ToTable(x => x.HasCheckConstraint("CH_Ingratiate_IngredientName", "LEN(IngredientName) >= 3 AND LEN(IngredientName) <= 20"));

            builder.Property(x => x.Description).IsRequired(true);
            builder.HasIndex(x => x.Description).IsUnique(false);
            builder.ToTable(x => x.HasCheckConstraint("CH_Ingratiate_Description", "LEN(Description) >= 10 AND LEN(Description) <= 50"));

            builder.ToTable(x => x.HasCheckConstraint("CH_Ingratiate_Quantity", "(Quantity) >= 0"));
            builder.Property(x => x.Quantity).HasDefaultValue(0);

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);




        }
    }
}
