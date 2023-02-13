using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.RepositoryData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace ExamensArbeteMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountData _accountData;
        public AccountController(IAccountData accountData)
        {
            _accountData = accountData;
        }
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }
        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel userModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountData.CreateUserAsync(userModel);
                //if (result.Succeeded)
                //{
                //    return RedirectToAction(nameof(SignIn));
                //}
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View();
                }
                ModelState.Clear();
            }
            return View();
        }
        [Route("login")]
        public IActionResult LogIn()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public async Task <IActionResult>  LogIn(LogInModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountData.PasswordSignInAsync(loginModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid input");
            }
            return View(loginModel);
        }

        [Route("logout")]
        public async Task<IActionResult> LogOut()
        {
            await _accountData.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
