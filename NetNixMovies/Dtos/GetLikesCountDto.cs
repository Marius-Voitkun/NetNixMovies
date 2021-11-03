using Newtonsoft.Json;

namespace NetNixMovies.Dtos
{
    public class GetLikesCountDto
    {
        public string MovieId { get; set; }

        [JsonProperty("like")]
        public float LikesCount { get; set; }
    }
}
