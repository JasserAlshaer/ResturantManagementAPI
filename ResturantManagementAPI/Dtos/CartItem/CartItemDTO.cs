namespace ResturantManagementAPI.Dtos.CartItem
{
    public class CartItemDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
        public int SelectedQtn { get; set; }
        public float NetAmount { get; set; }
    }
}
