using DigitalsoftWebApp.Models.Account;
using DigitalsoftWebApp.Models.DataSources;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Claims;
using api.digitalsoftec.net.Api;
using api.digitalsoftec.net.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DigitalsoftWebApp.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration) 
            : base(httpContextAccessor, configuration)
        {
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserRequest data)
        {
            UserApi api = new UserApi(_base_url);
            BusinessLayerSecurityUsersLoginUserRequest request = new BusinessLayerSecurityUsersLoginUserRequest()
            { email = data.email, password = data.password };

            try
            {
                BusinessLayerSecurityUsersLoggedUser user = await api.ApiUserLoginPostAsync(request);
                if (user != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.empleado.persona_apellidos + " " + user.empleado.persona_nombres),
                    new Claim(ClaimTypes.Name, user.username),
                    new Claim(ClaimTypes.Authentication, user.token),
                    new Claim(ClaimTypes.Email, user.email),
                };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties properties = new AuthenticationProperties()
                    {
                        AllowRefresh = true
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);

                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                ViewData["message_error"] = ex.Message;
            }
            return View(request);
        }

        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
