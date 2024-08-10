using Client.Data.IServices.IReadOnlyService;
using Client.DataTransferObj.Films;
using Client.ValueObj.Pagination;

namespace Client.Data.Services
{
    public class FilmService : IReadOnlyWPService<FilmDto, FilmsWithPaginationRequest>
    {
        HttpClient _httpClient;
        public FilmService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<PaginationResponse<FilmDto>> GetAll(FilmsWithPaginationRequest obj)
        {
            string url = $"https://localhost:7031/api/Films?Name={obj.Name}&Rating={obj.Rating}&Genre={obj.Genre}&Status={obj.Status}&Year={obj.Year}&PageNumber={obj.PageNumber}&PageSize={obj.PageSize}";
            return await _httpClient.GetFromJsonAsync<PaginationResponse<FilmDto>>(url);
        }

        public async Task<FilmDto> GetById(Guid id)
        {
            string url = $"https://localhost:7031/api/Films/id?id={id}";
            return await _httpClient.GetFromJsonAsync<FilmDto>(url);
        }
    }
}
