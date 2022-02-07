using Module5HW1.Enum;

namespace Module5HW1.Servicies
{
    public class UserService
    {
        private HttpService _httpService;
        private string _uri;

        public UserService(HttpService httpService, string uri)
        {
            _httpService = httpService;
            _uri = uri;
        }

        public async Task<string?> ListUsers()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/users?page=2",
                null);
        }

        public async Task<string?> SingleUser()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/users/2",
                null);
        }

        public async Task<string?> SingleUserNotFound()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/users/23",
                null);
        }
    }
}
