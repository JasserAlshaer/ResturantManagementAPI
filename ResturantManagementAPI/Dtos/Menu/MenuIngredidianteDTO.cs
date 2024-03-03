namespace ResturantManagementAPI.Dtos.Menu
{
    public class MenuIngratiateDTO
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; } //optional
    }
}
