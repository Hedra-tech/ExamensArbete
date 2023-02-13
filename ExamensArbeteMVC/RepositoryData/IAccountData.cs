using ExamensArbeteMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace ExamensArbeteMVC.RepositoryData
{
    public interface IAccountData
    {
        Task<IdentityResult> CreateUserAsync(SignUpModel userModel);
        Task<SignInResult> PasswordSignInAsync(LogInModel loginModel);
        Task SignOutAsync();
    }
}