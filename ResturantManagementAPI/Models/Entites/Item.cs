using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class Item : ParentEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual List<ItemIngratiate> ItemIngratiates { get; set; }
        public virtual List<MealItem> MealItems { get; set; }   
        public virtual List<CartItem> CartItems { get; set; }
    }
}
