using ResturantManagementAPI.Models.Shared;
using System.ComponentModel.DataAnnotations;
using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;
namespace ResturantManagementAPI.Models.Entites
{
    public class Cart : ParentEntity
    {
        public Status Status { get; set;}
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
    
}
