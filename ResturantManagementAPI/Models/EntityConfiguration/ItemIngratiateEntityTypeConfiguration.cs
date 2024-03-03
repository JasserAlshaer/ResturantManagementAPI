using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Models.EntityConfiguration
{
    public class ItemIngratiateEntityTypeConfiguration : IEntityTypeConfiguration<ItemIngratiate>
    {
        public void Configure(EntityTypeBuilder<ItemIngratiate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.ToTable(x => x.HasCheckConstraint("Qtn_ItemIngratiate_ch", "Qtn > 1"));

        }
    }
}
