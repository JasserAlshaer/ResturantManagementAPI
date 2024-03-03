using static ResturantManagementAPI.Helper.Enums.ResturnantManagementLookups;

namespace ResturantManagementAPI.Dtos.Order
{
    public class OrderRecordDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float TotalPrice { get; set; }
        public RecivingMethod RecivieingMethod { get; set; }
        public Status Status { get; set; }
        public int Username { get; set; }
        public int UserId { get; set; }
    }
}
