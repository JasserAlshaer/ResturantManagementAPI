namespace ResturantManagementAPI.Models.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public float PromoCode { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Cart Cart { get; set; }  
    }
}
