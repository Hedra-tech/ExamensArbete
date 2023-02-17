using ExamensArbeteMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace ExamensArbeteMVC.RepositoryData
{
    public class AccountData : IAccountData
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public AccountData(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;

        }
        public async Task<IdentityResult> CreateUserAsync(SignUpModel userModel)
        {
            var user = new IdentityUser()
            {
                Email = userModel.Email,
                UserName = userModel.Email
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }
        public async Task<SignInResult> PasswordSignInAsync(LogInModel loginModel)
        {
            return await _signinManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);


        }
        public async Task SignOutAsync()
        {
            await _signinManager.SignOutAsync();
        }
    }
}
