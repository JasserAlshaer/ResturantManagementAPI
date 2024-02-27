using ResturantManagementAPI.Dtos.Login;
using ResturantManagementAPI.Dtos.Menu;

namespace ResturantManagementAPI.Interfaces
{
    public interface ISharedInterface
    {
        Task Login(LoginReqDTO dto);
        //Logout
        //CreateAccount
        //ResetPassword
        //UpdateProfile
        //ViewMenu
        Task<List<MenuItemDTO>> ViewMenu(bool isAdmin = false);
    }
}
