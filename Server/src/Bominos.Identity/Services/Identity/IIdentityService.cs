namespace Bominos.Identity.Services.Identity
{
    using Bominos.Identity.Data.Models;
    using Bominos.Identity.Models.Identity;
    using Bominos.Models;
    
    using System.Threading.Tasks;

    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}