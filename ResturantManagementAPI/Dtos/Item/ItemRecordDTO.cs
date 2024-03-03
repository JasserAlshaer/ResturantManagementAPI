namespace ResturantManagementAPI.Dtos.Item
{
    public class ItemRecordDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
