using AutoMapper;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly IMapper _mapper;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(IMapper mapper,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) 
        {
			_mapper = mapper;
			_userManager = userManager;
			_signInManager = signInManager;
		}
        #region Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var mappedUser = _mapper.Map<RegisterViewModel, IdentityUser>(model);
                var user = new ApplicationUser()
                {
                    UserName = model.Email.Split("@")[0],
                    Email = model.Email,
                    IsAgree = model.IsAgree,
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
			return View(model);
		}
        #endregion

        #region Login

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    bool flag = await _userManager.CheckPasswordAsync(user, model.Password);
                    if (flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user , model.Password,model.RememberMe,false);
                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }
					ModelState.AddModelError(string.Empty, "Password is incorrect");
				}
                ModelState.AddModelError(string.Empty, "Email is not Existed");
            }
            return View(model);
        }

        #endregion

        #region SignOut

        // We Used the word new cuz the class controller base have a function called signout so we write new to ignore the ine at controller base.
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        #endregion
    }
}
