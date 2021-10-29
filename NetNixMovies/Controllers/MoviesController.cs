using Microsoft.AspNetCore.Mvc;
using NetNixMovies.Services;
using System.Threading.Tasks;

namespace NetNixMovies.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _moviesService.GetUpcomingMoviesAsync());
        }

        public async Task<IActionResult> Details(string movieId, string directorId)
        {
            return View(await _moviesService.GetMovieAsync(movieId, directorId));
        }
    }
}
