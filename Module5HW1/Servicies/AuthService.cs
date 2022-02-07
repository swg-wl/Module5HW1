using Module5HW1.Enum;

namespace Module5HW1.Servicies
{
    public class AuthService
    {
        private HttpService _httpService;
        private string _uri;

        public AuthService(HttpService httpService, string uri)
        {
            _httpService = httpService;
            _uri = uri;
        }

        public async Task<string?> RegisterSuccessful()
        {
            return await _httpService.SendAsync(
                RequestType.Post,
                _uri + "/api/register",
                "{\"email\":\"eve.holt@reqres.in\",\"password\":\"pistol\"}");
        }

        public async Task<string?> RegisterUnsuccessful()
        {
            return await _httpService.SendAsync(
                RequestType.Post,
                _uri + "/api/register",
                "{\"email\":\"sydney@fife\"}");
        }

        public async Task<string?> LoginSuccessful()
        {
            return await _httpService.SendAsync(
                RequestType.Post,
                _uri + "/api/login",
                "{\"email\":\"eve.holt@reqres.in\",\"password\":\"cityslicka\"}");
        }

        public async Task<string?> LoginUnsuccessful()
        {
            return await _httpService.SendAsync(
                RequestType.Post,
                _uri + "/api/login",
                "{\"email\":\"peter@klaven\"}");
        }

        public async Task<string?> DelayedResponse()
        {
            return await _httpService.SendAsync(
                RequestType.Get,
                _uri + "/api/users?delay=3",
                null);
        }
    }
}
