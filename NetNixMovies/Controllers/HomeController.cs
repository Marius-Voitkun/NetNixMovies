using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetNixMovies.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetNixMovies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            string responseBody = await client.GetStringAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/soon/");

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
