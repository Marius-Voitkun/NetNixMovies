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

        public async Task<IActionResult> Index() =>
            View(await _moviesService.GetUpcomingMoviesAsync());

        public async Task<IActionResult> Details(string movieId, string directorId) =>
            View(await _moviesService.GetMovieDetailsViewModelAsync(movieId, directorId));
    }
}
