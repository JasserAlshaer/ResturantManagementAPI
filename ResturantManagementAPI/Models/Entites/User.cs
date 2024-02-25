using ResturantManagementAPI.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace ResturantManagementAPI.Models.Entites
{
    public class User:ParentEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string ProfileImagePath { get; set; }
        public string SerialNumber { get; set; } //Ad-1,EMP-1,Client-1
        public string UserType { get; set; }//column
        public virtual List<Cart> Carts { get; set; }
    }
}
