using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemIngredidianteEntityTypeConfiguration : IEntityTypeConfiguration<ItemIngredidiante>
    {
        public void Configure(EntityTypeBuilder<ItemIngredidiante> builder)
        {
            builder.ToTable("ItemIngredidiantes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Qtn).IsRequired(true);
            


            builder.ToTable(x => x.HasCheckConstraint("CH_ItemIngredidianteQTYNotZero", "Qtn > 0"));

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        }
    }
}
