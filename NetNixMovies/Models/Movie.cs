using Newtonsoft.Json;
using System;

namespace NetNixMovies.Models
{
    public class Movie
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [JsonProperty("image:")]
        public string ImageUrl { get; set; }

        public Director Director { get; set; }
    }
}
