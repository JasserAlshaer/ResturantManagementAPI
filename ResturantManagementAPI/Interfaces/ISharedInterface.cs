using ResturantManagementAPI.Dtos.Account;
using ResturantManagementAPI.Dtos.Login;
using ResturantManagementAPI.Dtos.Menu;

namespace ResturantManagementAPI.Interfaces
{
    public interface ISharedInterface
    {
        Task<int> Login(LoginReqDTO dto);
        //Logout
        Task Logout(int userId);
        //CreateAccount
        Task CreateAccount(RegistrationDTO dto);
        //ResetPassword
        Task ResetPassword(ResetPasswordDTO dto);
        //UpdateProfile
        Task UpdateProfile(UpdateProfileDTO dto);
        //ViewMenu
        Task<List<MenuItemDTO>> ViewMenu(bool isAdmin = false);
        //View MenuItem Details 
        Task<MenuItemDetailsDTO> ViewMenuItemDetailsDTO(int menuItemId,bool isItem=true);

        //Mange Cart Item and Selection 
        Task AddItemsInCart(int cartId, int itemid, int qtn, string note);
        Task UpdateItemsInCart(int cartItemId, int qtn, string note);
        Task DeleteItemsInCart(int cartItemId);
    }
}
