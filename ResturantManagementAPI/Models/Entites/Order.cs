using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class Order : ParentEntity
    {
        public string Title { get; set; }
        public float NetPrice { get; set; }
        public float TaxAmount { get; set; }
        public float DiscountAmount { get; set; }
        public string RecivieingMethod { get; set; }
        public string Status { get; set; }
        public string DelievryManPhone { get; set; }
        public float TotalPrice { get; set; }        public float PromoCode { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Cart Cart { get; set; }  
    }
}
