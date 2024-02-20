using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace ResturantManagementAPI.Models.Entites
{
    public class ItemIngredidiante
    {
        public int Id { get; set; }
        public float Qtn { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Ingredidiante Ingredidiante { get; set; }
        public virtual Item Item { get; set; }
    }
}
