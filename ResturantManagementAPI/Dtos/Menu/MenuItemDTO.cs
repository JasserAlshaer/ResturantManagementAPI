namespace ResturantManagementAPI.Dtos.Menu
{
    public class MenuItemDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Qtn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
