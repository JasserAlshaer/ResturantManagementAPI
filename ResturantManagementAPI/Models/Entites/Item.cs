namespace ResturantManagementAPI.Models.Entites
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public virtual List<ItemIngredidiante> ItemIngredidiantes { get; set; }
        public virtual List<MealItem> MealItems { get; set; }   
        public virtual List<CartItem> CartItems { get; set; }
    }
}
