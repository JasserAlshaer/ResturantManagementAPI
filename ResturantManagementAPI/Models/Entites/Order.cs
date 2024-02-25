using ResturantManagementAPI.Models.Shared;
using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;
namespace ResturantManagementAPI.Models.Entites
{
    public class Order : ParentEntity
    {
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
        public virtual Cart Cart { get; set; }  
    }
}
