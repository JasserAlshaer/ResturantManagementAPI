using ResturantManagementAPI.Dtos.Order;
using ResturantManagementAPI.Interfaces;

namespace ResturantManagementAPI.Implmentations
{
    public class ClientImplementation : IClientInterface
    {
        public Task CreateOrder(CheckOrderByClientDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderRecordDTO>> GetAllOrderHistory()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
