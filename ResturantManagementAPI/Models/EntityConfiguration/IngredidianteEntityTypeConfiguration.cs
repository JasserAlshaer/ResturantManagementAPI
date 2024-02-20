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
        }
    }
}
