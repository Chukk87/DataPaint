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
    [Route("UserAccount")]
    public class UserAccountController : Controller
    {
        private ILoginService _loginService;

        public UserAccountController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [Route("Login")]
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
            return RedirectToAction("Login", "UserAccount");
        }

        [Route("LoginUser")]
        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                var authenticationResult = await _loginService.ValidateUserAsync(model.Username, model.Password);

                if (authenticationResult.AuthenticationType == AuthenticationType.Valid)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username)
                    };

                    if(authenticationResult.IsAdmin)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                    }
                    else
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "User"));
                    }

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    switch (authenticationResult.AuthenticationType)
                    {
                        case AuthenticationType.Unknown:
                            TempData["Status"] = "Unknown";
                            break;
                        case AuthenticationType.IncorrectPassword:
                            TempData["Status"] = "IncorrectPassword";
                            break;
                        case AuthenticationType.Locked:
                            TempData["Status"] = "Locked";
                            break;
                    }
                }
            }

            return View("_Login");
        }
    }
}