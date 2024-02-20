namespace ResturantManagementAPI.Models.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Cart Cart { get; set; }  
    }
}
