using Client.Data.IServices.IReadOnlyService;
using Client.DataTransferObj.Genres;

namespace Client.Data.Services
{
    public class GenreService : IReadOnlyNPService<GenreDto>
    {
        HttpClient _httpClient;
        public GenreService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ICollection<GenreDto>> GetAllAsync(string name, Guid id)
        {
            string url = $"https://localhost:7031/api/Genres/name";
            return await _httpClient.GetFromJsonAsync<List<GenreDto>>(url);
        }

        public async Task<GenreDto> GetByIdAsync(string? id)
        {
            string url = $"";
            return await _httpClient.GetFromJsonAsync<GenreDto>(url);
        }
    }
}
