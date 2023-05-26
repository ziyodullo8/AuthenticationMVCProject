using AuthMVCProject.Models.DTO;

namespace AuthMVCProject.Repository.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task<Status> RegistrationAsynnc(RegistrationModel model);
        Task LogoutAsync();
    }
}
