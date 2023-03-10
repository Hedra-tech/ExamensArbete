using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.RepositoryData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace ExamensArbeteMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountData _accountData;

        public readonly SignInManager<IdentityUser> SignInManager;
        public AccountController(IAccountData accountData, SignInManager<IdentityUser> signInManager)
        {
            _accountData = accountData;
            SignInManager = signInManager;
        }
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }
        //public IActionResult SignUp(bool isSuccess = false)
        //{
        //    ViewBag.IsSuccess = isSuccess;
        //    return View();
        //}
        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel userModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountData.CreateUserAsync(userModel);
                if (result.Succeeded)
                {
                    TempData["Message"] = "Your account has been created successfully. You can log in now";
                    return RedirectToAction("LogIn", "Account");
                }
                ModelState.AddModelError("", "Invalid input");
            }
            return View(userModel);
        }

        [Route("login")]
        public IActionResult LogIn()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInModel loginModel)
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
