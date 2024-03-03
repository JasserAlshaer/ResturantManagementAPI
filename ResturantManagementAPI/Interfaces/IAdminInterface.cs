using ResturantManagementAPI.Dtos.Ingratiate;
using ResturantManagementAPI.Dtos.Item;
using ResturantManagementAPI.Dtos.Meal;
using ResturantManagementAPI.Dtos.Order;
using ResturantManagementAPI.Dtos.User;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Interfaces
{
    public interface IAdminInterface
    {
        //Ingratiate Management
        Task<List<IngratiateRecordDTO>> GetAllIngratiate();
        Task<IngratiateDetailsDTO> GetIngratiateById(int Id);
        Task CreateIngratiate(CreateIngratieDTO dto);
        Task UpdateIngratiate(UpdateIngratiateDTO dto);
        Task DeleteIngratiate(int Id);
        //Item Management
        Task<List<ItemRecordDTO>> GetAllItems();
        Task<ItemDetailsDTO> GeItemById(int Id);
        Task CreateItem(CreateOrUpdateMeal dto);
        Task UpdateItem(CreateOrUpdateMeal dto);
        Task DeleteItem(int Id);
        //Meal Management
        Task<List<MealRecordDTO>> GetAllMeals();
        Task <MealDetailsDTO>GeMealById(int Id);
        Task CreateMeal(CreateOrUpdateMeal dto);
        Task UpdateMeal(CreateOrUpdateMeal dto);
        Task DeleteMeal(int Id);
        //User Management 
        Task<List<UserRecordDTO>> GetAllUsers();
        Task <UserRecordDTO> GeUserById(int Id);
        Task DeleteUser(int Id);
        //Order Management
        Task<List<OrderRecordDTO>> GetAllOrder();
        Task<OrderDetailsDTO> GetOrderById(int Id);
    }
}
