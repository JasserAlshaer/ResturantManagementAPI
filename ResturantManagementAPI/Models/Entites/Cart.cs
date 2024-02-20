using System.ComponentModel.DataAnnotations;

namespace ResturantManagementAPI.Models.Entites
{
    public class Cart
    {
        public int Id { get; set; }

        public string Status { get; set;}
        
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
    
}
