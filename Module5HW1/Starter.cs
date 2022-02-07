using Module5HW1.Models;
using Module5HW1.Servicies;

namespace ModuleHW1
{
    public class Starter
    {
        private HttpClient _httpClient;
        private HttpService _httpService;
        private ConfigurationService _configurationService;
        private UserService _userService;
        private AuthService _authService;
        private ResourceService _resourceService;

        public Starter()
        {
            _configurationService = new ConfigurationService();
            Configuration configuration = _configurationService.Load();

            _httpClient = new HttpClient();
            _httpService = new HttpService(_httpClient);
            _resourceService = new ResourceService(_httpService, configuration.Url!);
            _userService = new UserService(_httpService, configuration.Url!);
            _authService = new AuthService(_httpService, configuration.Url!);
        }

        public async void RunAsync()
        {
            var result = new List<string?>();

            result.Add(await _userService.ListUsers());
            result.Add(await _userService.SingleUser());
            result.Add(await _userService.SingleUserNotFound());
            result.Add(await _authService.LoginUnsuccessful());
            result.Add(await _authService.LoginSuccessful());
            result.Add(await _authService.DelayedResponse());
            result.Add(await _authService.RegisterUnsuccessful());
            result.Add(await _authService.RegisterSuccessful());
            result.Add(await _resourceService.SingleResource());
            result.Add(await _resourceService.ListResource());
            result.Add(await _resourceService.PatchUpdate());
            result.Add(await _resourceService.PutUpdate());
            result.Add(await _resourceService.Delete());
            result.Add(await _resourceService.PostCreate());
            result.Add(await _resourceService.SingleResourceNotFound());
        }
    }
}