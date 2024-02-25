using ResturantManagementAPI.Dtos.Login;

namespace ResturantManagementAPI.Interfaces
{
    public interface ISharedInterface
    {
        Task Login(LoginReqDTO dto); 
    }
}
