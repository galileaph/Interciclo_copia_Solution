using api.digitalsoftec.net.Client;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Security.Claims;

namespace DigitalsoftWebApp.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly IConfiguration _configuration;
        protected readonly ClaimsPrincipal? _user;
        protected string? _token;
        protected string _base_url;
        protected Configuration _apiConfiguration;
        protected void ConfigureUserData()
        {
            if (_user != null)
            {
                var username = _user!.FindFirst(ClaimTypes.Name)?.Value;
                var email = _user.FindFirst(ClaimTypes.Email)?.Value;

                ViewData["username"] = username;
                ViewData["email"] = email;
            }
        }
        public BaseController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext!.User;
            _configuration = configuration;
            _base_url = _configuration["ds_base_url"];

            _token = _user.FindFirst(ClaimTypes.Authentication)?.Value;
            _apiConfiguration = new Configuration();
            _apiConfiguration.BasePath = _base_url;
            _apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);

        }
    }
}
