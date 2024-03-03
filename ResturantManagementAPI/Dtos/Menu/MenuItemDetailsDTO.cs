using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Dtos.Menu
{
    public class MenuItemDetailsDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Qtn { get; set; }
        public bool IsDeleted { get; set; }
        public List<MenuItemDTO> Items { get; set; }  //by default allow null
        public List<MenuIngratiateDTO> Ingratiates { get; set; }//by default allow null
    }
}
