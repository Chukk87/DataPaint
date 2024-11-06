using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using DataPaintWebApp.Model;
using DataPaintLibrary.Enums;
using System.Threading.Tasks;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Services.Classes;

namespace DataPaintWebApp.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("_Login");
        }

        [Route("Logout")]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                // Replace with your actual authentication logic
                var authenticationResult = await _loginService.ValidateUserAsync(model.Username, model.Password);

                if (authenticationResult == AuthenticationType.Valid)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    // Set up cookie options for "Remember Me" functionality
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);

                    return RedirectToAction("Index", "Home"); // Redirect to home or other page
                }
                else
                {
                    switch(authenticationResult)
                    {
                        case AuthenticationType.Unknown:
                            ModelState.AddModelError(string.Empty, "Unknown User");
                            break;
                        case AuthenticationType.IncorrectPassword:
                            ModelState.AddModelError(string.Empty, "Incorrect Password");
                            break;
                        case AuthenticationType.Locked:
                            ModelState.AddModelError(string.Empty, "Locked Account");
                            break;
                    }
                }
            }

            return View("_Login");
        }
    }
}