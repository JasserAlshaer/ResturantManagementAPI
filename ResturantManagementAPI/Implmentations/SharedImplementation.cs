using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ResturantManagementAPI.Dtos.Account;
using ResturantManagementAPI.Dtos.Login;
using ResturantManagementAPI.Dtos.Menu;
using ResturantManagementAPI.Interfaces;
using ResturantManagementAPI.Models.Context;
using ResturantManagementAPI.Models.Entites;

namespace ResturantManagementAPI.Implmentations
{
    public class SharedImplementation : ISharedInterface
    {
        private readonly ResturantManagementDbContext _context;
        public SharedImplementation(ResturantManagementDbContext context)
        {
            //context
            _context=context;
        }
        public async Task<List<Ingratiate>> GetAllIngratiatesInDb()
        {
            string query = "select * from Ingratiates";
            return await _context.Ingredidiantes.ToListAsync();
        }
        public Task AddItemsInCart(int cartId, int itemid, int qtn, string note)
        {
            throw new NotImplementedException();
        }

        public Task CreateAccount(RegistrationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemsInCart(int cartItemId)
        {
            throw new NotImplementedException();
        }



        public Task<int> Login(LoginReqDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(ResetPasswordDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemsInCart(int cartItemId, int qtn, string note)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProfile(UpdateProfileDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuItemDTO>> ViewMenu(bool isAdmin = false)
        {
            throw new NotImplementedException();
        }

        public Task<MenuItemDetailsDTO> ViewMenuItemDetailsDTO(int menuItemId, bool isItem = true)
        {
            throw new NotImplementedException();
        }
    }
}
