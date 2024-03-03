namespace ResturantManagementAPI.Dtos.Meal
{
    public class MealRecordDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
