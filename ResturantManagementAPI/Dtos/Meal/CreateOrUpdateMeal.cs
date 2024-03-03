using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Dtos.Item
{
    public class CreateOrUpdateMeal
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public List<SelectedItemDTO> SelectedItems { get; set; }
    }
}
