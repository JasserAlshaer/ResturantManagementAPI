namespace ResturantManagementAPI.Dtos.Ingratiate
{
    public class CreateIngratieDTO
    {
        public float PricePerUnit { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
