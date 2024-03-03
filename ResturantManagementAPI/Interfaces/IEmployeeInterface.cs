using ResturantManagementAPI.Dtos.Order;

namespace ResturantManagementAPI.Interfaces
{
    public interface IEmployeeInterface
    {
        //Cart Management 
        Task CreateCart(int userId);
        Task DeleteCart(int cartId);
        //Order Management
        Task CheckoutOrder(CheckoutOrderDTO dto);
        Task PrintInvoice(int OrderId);
    }
}
