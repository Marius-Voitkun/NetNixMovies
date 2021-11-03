using NetNixMovies.Dtos;
using NetNixMovies.Models;
using NetNixMovies.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetNixMovies.Services
{
    public class MoviesService
    {
        private readonly DataService _dataService;

        public MoviesService(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<List<Movie>> GetUpcomingMoviesAsync()
        {
            var responseString = await _dataService.GetDataFromApiAsync("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/soon/");

            return JsonConvert.DeserializeObject<List<Movie>>(responseString);
        }

        public async Task<MovieDetailsViewModel> GetMovieDetailsViewModelAsync(string movieId, string directorId)
        {
            return new MovieDetailsViewModel
            {
                Movie = await GetMovieAsync(movieId, directorId),
                LikesCount = await GetLikesCountAsync(movieId),
                IsLiked = false
            };
        }

        private async Task<Movie> GetMovieAsync(string movieId, string directorId)
        {
            var responseString = await _dataService.GetDataFromApiAsync($"https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/movie/{movieId}");

            var movie = JsonConvert.DeserializeObject<Movie>(responseString);
            movie.Director.Id = directorId;

            return movie;
        }

        private async Task<int> GetLikesCountAsync(string movieId)
        {
            var responseString = await _dataService.GetDataFromApiAsync($"https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/like/{movieId}");

            var dto = JsonConvert.DeserializeObject<GetLikesCountDto>(responseString);

            return (int)dto.LikesCount;
        }
    }
}
