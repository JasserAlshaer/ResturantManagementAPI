using Microsoft.AspNetCore.Components.Web.Virtualization;
using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class ItemIngredidiante : ParentEntity
    {
        
        public float Qtn { get; set; }
        public virtual Ingredidiante Ingredidiante { get; set; }
        public virtual Item Item { get; set; }
    }
}
