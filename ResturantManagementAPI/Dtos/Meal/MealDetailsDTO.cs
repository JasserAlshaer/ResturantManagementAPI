using ResturantManagementAPI.Dtos.ItemIngratiates;
using ResturantManagementAPI.Dtos.MealItem;

namespace ResturantManagementAPI.Dtos.Meal
{
    public class MealDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public List<MealItemRecordDTO> MealItem { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
