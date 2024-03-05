using ResturantManagementAPI.Dtos.Order;
using ResturantManagementAPI.Interfaces;

namespace ResturantManagementAPI.Implmentations
{
    public class EmployeeImplementation : IEmployeeInterface
    {
        public Task CheckoutOrder(CheckoutOrderDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateCart(int userId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCart(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task PrintInvoice(int OrderId)
        {
            throw new NotImplementedException();
        }
    }
}
