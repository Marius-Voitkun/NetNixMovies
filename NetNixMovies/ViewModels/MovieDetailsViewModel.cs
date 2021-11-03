using NetNixMovies.Models;

namespace NetNixMovies.ViewModels
{
    public class MovieDetailsViewModel
    {
        public Movie Movie { get; set; }

        public int LikesCount { get; set; }

        public bool IsLiked { get; set; }
    }
}
