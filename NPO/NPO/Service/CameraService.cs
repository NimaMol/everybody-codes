using NPO.Model;

namespace NPO.Service
{
    public interface ICameraService
    {
        Task<IEnumerable<CameraModel>> GetAllCamerasAsync();
    }

public class CameraService : ICameraService
    {
        private readonly HttpClient _httpClient;

        public CameraService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CameraModel>> GetAllCamerasAsync()
        {
            var uri = "/api/CameraApi/GetAll";
            var response = await _httpClient.GetAsync(uri);
            var cameras = await response.Content.ReadFromJsonAsync<IEnumerable<CameraModel>>();

            return cameras ?? new List<CameraModel>();
        }
    }
}