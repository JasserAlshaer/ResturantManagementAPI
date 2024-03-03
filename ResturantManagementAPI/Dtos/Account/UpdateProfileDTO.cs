namespace ResturantManagementAPI.Dtos.Account
{
    public class UpdateProfileDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string ProfileImagePath { get; set; }
    }
}
