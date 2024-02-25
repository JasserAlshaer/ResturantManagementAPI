using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemIngredidianteEntityTypeConfiguration : IEntityTypeConfiguration<ItemIngredidiante>
    {
        public void Configure(EntityTypeBuilder<ItemIngredidiante> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.ToTable(x => x.HasCheckConstraint("Qtn_ItemIngredidiante_ch", "Qtn > 1"));

        }
    }
}
