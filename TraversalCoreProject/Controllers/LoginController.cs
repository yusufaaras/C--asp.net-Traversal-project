using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;
using System.Threading.Tasks; // async/await için gerekli using ifadesi
using EntityLayer.Concrete;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _UserManager;
        private readonly SignInManager<AppUser> _SignInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        [HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegistorViewModel p) // async eklendi
		{
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                Email = p.Mail,
                UserName = p.UserName
            };
            if (p.Password == p.ConifrmPassword)
            {
                var result = await _UserManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
        [HttpPost]
        public async Task <IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _SignInManager.PasswordSignInAsync(p.UserName,p.Password,false,true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new {Area="Member"});
                }
                else
                {
                    return RedirectToAction("SignIn","Login");
                }
            }
            return View();
        }
	}
}
