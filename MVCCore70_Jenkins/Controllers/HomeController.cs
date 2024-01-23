using Microsoft.AspNetCore.Mvc;
using MVCCore70_Jenkins.Models;
using System.Diagnostics;

namespace MVCCore70_Jenkins.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IConfiguration config;
        string appTitle = "Default Local";
        string appLink = "";
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            config = configuration;
            //var sct = config.GetRequiredSection("Settings").Get<Settings>();
            //var sct = config.GetRequiredSection("AppTitle").Get<Settings>();
            //appTitle = config.GetValue("System.String", "AppTitle").ToString();
            appTitle = configuration.GetSection("AppTitle")?.Value;
            appLink = configuration.GetSection("AppLink")?.Value;
        }

        public IActionResult Index()
        {
            ViewBag.AppTitle = appTitle;
            ViewBag.AppLink = appLink;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
