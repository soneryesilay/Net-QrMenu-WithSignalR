using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QrMenu.EntityLayer.Entities;
using QrMenuWebUI.Dtos.IdentityDtos;

namespace QrMenuWebUI.Controllers
{
    public class RegsiterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegsiterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            var appUser = new AppUser
            {
                Name = registerDto.Name,
                Surname = registerDto.Surname,
                UserName = registerDto.UserName,
                Email = registerDto.Mail
            };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
