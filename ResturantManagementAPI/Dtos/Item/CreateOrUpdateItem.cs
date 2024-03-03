using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Dtos.Item
{
    public class CreateOrUpdateItem
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public List<SelectedIngratiateDTO> Ingratiates { get; set; }
    }
}
