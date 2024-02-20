namespace ResturantManagementAPI.Models.Entites
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Qtn { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Item? Item { get; set; }  
        public virtual Meal? Meal { get; set; }
        public virtual Cart Cart { get; set; }  
    }
}
