using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class IngredidianteEntityTypeConfiguration : IEntityTypeConfiguration<Ingredidiante>
    {
        public void Configure(EntityTypeBuilder<Ingredidiante> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.ToTable(x => x.HasCheckConstraint("price", "PricePerUnit > 0"));
            builder.ToTable(x => x.HasCheckConstraint("StockQu", "StockQuantity > 10"));

             

        }
    }
}
