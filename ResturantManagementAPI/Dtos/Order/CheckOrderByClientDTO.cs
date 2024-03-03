using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;

namespace ResturantManagementAPI.Dtos.Order
{
    public class CheckOrderByClientDTO
    {
        public int OrderId { get; set; }
        public float PromoCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public RecivingMethod RecivieingMethod { get; set; }
    }
}
