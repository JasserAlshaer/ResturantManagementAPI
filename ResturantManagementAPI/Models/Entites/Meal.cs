using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class Meal : ParentEntity
    { 
        public string Name  { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImagePath { get; set; }
        public virtual List<MealItem> MealItems { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
