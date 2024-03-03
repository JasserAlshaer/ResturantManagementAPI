using Microsoft.AspNetCore.Components.Web.Virtualization;
using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class ItemIngratiate : ParentEntity
    {
        
        public float Qtn { get; set; }
        public virtual Ingratiate Ingratiate { get; set; }
        public virtual Item Item { get; set; }
    }
}
