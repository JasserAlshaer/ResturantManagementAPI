namespace ResturantManagementAPI.Models.Entites
{
    public class Meal
    {
        public int MealID { get; set; }
        public int ItemId { get; set; }
        public int ItemMealId { get; set; }
        public int CartItemMeal { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
    }
}
