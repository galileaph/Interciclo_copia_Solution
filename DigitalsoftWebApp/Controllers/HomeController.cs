using DigitalsoftWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace DigitalsoftWebApp.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public HomeController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpContextAccessor, configuration) 
        {
        }

        public IActionResult Index()
        {
            ConfigureUserData();
            return View();
        }

        public IActionResult Privacy()
        {
            ConfigureUserData();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}