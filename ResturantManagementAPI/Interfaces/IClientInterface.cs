using ResturantManagementAPI.Dtos.Order;

namespace ResturantManagementAPI.Interfaces
{
    public interface IClientInterface
    {
        //Manage Order
        Task CreateOrder(CheckOrderByClientDTO dto);
        Task<List<OrderRecordDTO>> GetAllOrderHistory();
        Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id);
    }
}
