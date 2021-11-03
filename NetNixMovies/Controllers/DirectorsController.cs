using Microsoft.AspNetCore.Mvc;
using NetNixMovies.Services;
using System.Threading.Tasks;

namespace NetNixMovies.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly DirectorsService _directorsService;

        public DirectorsController(DirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        public async Task<IActionResult> Details(string id) =>
            View(await _directorsService.GetDirectorAsync(id));
    }
}
