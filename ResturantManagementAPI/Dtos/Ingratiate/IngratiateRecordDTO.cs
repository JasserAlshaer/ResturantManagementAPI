namespace ResturantManagementAPI.Dtos.Ingratiate
{
    public class IngratiateRecordDTO
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public float PricePerUnit { get; set; }
        public bool IsDeleted { get; set; }
    }
}
