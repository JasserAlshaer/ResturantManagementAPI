using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemIngredidiantsEntityTypeConfiguration : IEntityTypeConfiguration<ItemIngredidiante>
    {
        public void Configure(EntityTypeBuilder<ItemIngredidiante> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
