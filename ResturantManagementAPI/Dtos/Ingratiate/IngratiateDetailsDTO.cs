namespace ResturantManagementAPI.Dtos.Ingratiate
{
    public class IngratiateDetailsDTO
    {
        public int Id { get; set; }
        public float PricePerUnit { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
