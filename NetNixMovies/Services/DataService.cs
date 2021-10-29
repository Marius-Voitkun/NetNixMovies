using System.Net.Http;
using System.Threading.Tasks;

namespace NetNixMovies.Services
{
    public class DataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDataFromApiAsync(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }
    }
}
