using Module5HW1.Enum;

namespace Module5HW1.Servicies
{
    public class ResourceService
    {
        private HttpService _httpService;
        private string _uri;

        public ResourceService(HttpService httpService, string uri)
        {
            _httpService = httpService;
            _uri = uri;
        }

        public async Task<string?> ListResource()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/unknown",
                null);
        }

        public async Task<string?> SingleResource()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/unknown/2",
                null);
        }

        public async Task<string?> SingleResourceNotFound()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/users/23",
                null);
        }

        public async Task<string?> PostCreate()
        {
            return await _httpService.SendAsync(
                RequestType.Post,
                _uri + "/api/users",
                "{\"name\":\"morpheus\",\"job\":\"leader\"}");
        }

        public async Task<string?> PutUpdate()
        {
            return await _httpService.SendAsync(
                RequestType.Put,
                _uri + "/api/users/2",
                "{\"name\":\"morpheus\",\"job\":\"zionresident\"}");
        }

        public async Task<string?> PatchUpdate()
        {
            return await _httpService.SendAsync(
                RequestType.Patch,
                _uri + "/api/users/2",
                "{\"name\":\"morpheus\",\"job\":\"zionresident\"}");
        }

        public async Task<string?> Delete()
        {
            return await _httpService.SendAsync(
                RequestType.Delete,
                _uri + "/api/users/2",
                null);
        }
    }
}
