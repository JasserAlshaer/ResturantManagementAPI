using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;

namespace ResturantManagementAPI.Dtos.Order
{
    public class CheckoutOrderDTO
    {
        public int OrderId { get; set; }
        public string Title { get; set; }
        public float TaxAmount { get; set; }
        public float DiscountAmount { get; set; }
        public RecivingMethod RecivieingMethod { get; set; }
        public Status Status { get; set; }
        public string DelievryManPhone { get; set; }
        public float PromoCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
