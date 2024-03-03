using ResturantManagementAPI.Dtos.CartItem;
using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;

namespace ResturantManagementAPI.Dtos.Order
{
    public class OrderDetailsDTO
    {
        public int OrderId { get; set; }
        public string Title { get; set; }
        public float NetPrice { get; set; }
        public float TaxAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalPrice { get; set; }
        public RecivingMethod RecivieingMethod { get; set; }
        public Status Status { get; set; }
        public string DelievryManPhone { get; set; }
        public float PromoCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDateTime { get; set; }
        public List<CartItemDTO> CartItems { get; set; }
        public string Username { get; set; }
        public string UserPhone { get; set; }

    }
}
