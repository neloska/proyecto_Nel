using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Data;
using proyecto_Nel.Data.Static;
using proyecto_Nel.Data.ViewModels;
using proyecto_Nel.Models;
using System.Threading.Tasks;

namespace proyecto_Nel.Controllers
{
    public class CuentaController : Controller
    {
        private readonly UserManager<usuarioApp> _userManager;
        private readonly SignInManager<usuarioApp> _signInManager;
        private readonly AppDbContext _context;
        public CuentaController(UserManager<usuarioApp> userManager, SignInManager<usuarioApp> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context; 
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            //si el usuario no es nulo checkeamos que la contraseña coicide
            if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result= await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["Error"] = "Datos no coincidentes. Pruebe otra vez";
                return View(loginVM);
            }
            TempData["Error"] = "Datos no coincidentes. Pruebe otra vez";
            return View(loginVM);
        }

        public IActionResult Register()
        {
            return View(new RegisterVM());

        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(!ModelState.IsValid) return View(registerVM);

            //comprobamos si el usuario existe en nuestra base de datos
            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if(user != null)
            {
                TempData["Error"] = "Este correo se encuentra en uso";
            }

            var newUser = new usuarioApp()
            {
                NombreCompleto = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };
            var newUserResponse= await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, RolesUsuario.User);
            }

            return View("RegistroCompletado");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
