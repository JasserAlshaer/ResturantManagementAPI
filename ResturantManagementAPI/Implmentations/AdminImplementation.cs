using ResturantManagementAPI.Dtos.Ingratiate;
using ResturantManagementAPI.Dtos.Item;
using ResturantManagementAPI.Dtos.Meal;
using ResturantManagementAPI.Dtos.Order;
using ResturantManagementAPI.Dtos.User;
using ResturantManagementAPI.Interfaces;

namespace ResturantManagementAPI.Implmentations
{
    public class AdminImplementation : IAdminInterface
    {
        public Task CreateIngratiate(CreateIngratieDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateItem(CreateOrUpdateMeal dto)
        {
            throw new NotImplementedException();
        }

        public Task CreateMeal(CreateOrUpdateMeal dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIngratiate(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMeal(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemDetailsDTO> GeItemById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MealDetailsDTO> GeMealById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IngratiateRecordDTO>> GetAllIngratiate()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemRecordDTO>> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Task<List<MealRecordDTO>> GetAllMeals()
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderRecordDTO>> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRecordDTO>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IngratiateDetailsDTO> GetIngratiateById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> GetOrderById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRecordDTO> GeUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIngratiate(UpdateIngratiateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(CreateOrUpdateMeal dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMeal(CreateOrUpdateMeal dto)
        {
            throw new NotImplementedException();
        }
    }
}
