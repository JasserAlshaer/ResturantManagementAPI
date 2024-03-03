using ResturantManagementAPI.Dtos.ItemIngratiates;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Dtos.Item
{
    public class ItemDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public List<ItemIngratiatesRecordDTO> ItemIngratiates { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
