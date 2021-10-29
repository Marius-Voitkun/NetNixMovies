using NetNixMovies.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NetNixMovies.Services
{
    public class DirectorsService
    {
        private readonly DataService _dataService;

        public DirectorsService(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<Director> GetDirectorAsync(string id)
        {
            var responseString = await _dataService.GetDataFromApiAsync($"https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/director/{id}");

            return JsonConvert.DeserializeObject<Director>(responseString);
        }
    }
}
