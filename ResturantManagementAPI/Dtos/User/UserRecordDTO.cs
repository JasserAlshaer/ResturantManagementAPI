using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;

namespace ResturantManagementAPI.Dtos.User
{
    public class UserRecordDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileImagePath { get; set; }
        public string SerialNumber { get; set; }
        public UserType UserType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
