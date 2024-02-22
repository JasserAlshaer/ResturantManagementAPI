using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class CartItem : ParentEntity
    {
        
        public int Qtn { get; set; }

        public virtual Item? Item { get; set; }  
        public virtual Meal? Meal { get; set; }
        public virtual Cart Cart { get; set; }  
    }
}
