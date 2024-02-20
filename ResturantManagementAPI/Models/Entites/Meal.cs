namespace ResturantManagementAPI.Models.Entites
{
    public class Meal
    {
        public int Id { get; set; }
       
        public string Name  { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<MealItem> MealItems { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
