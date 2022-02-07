using Module5HW1.Enum;

namespace Module5HW1.Servicies
{
    public class HttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string?> SendAsync(RequestType requestType, string uri, string? body)
        {
            string? result = null;
            StringContent content;
            HttpResponseMessage? response = null;

            if (requestType == RequestType.Get)
            {
                response = await _httpClient.GetAsync(uri);
            }
            else if (requestType == RequestType.Delete)
            {
                response = await _httpClient.DeleteAsync(uri);
            }
            else
            {
                if (body == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    content = new StringContent(body);
                }

                if (requestType == RequestType.Post)
                {
                    response = await _httpClient.PostAsync(uri, content);
                }
                else if (requestType == RequestType.Put)
                {
                    response = await _httpClient.PutAsync(uri, content);
                }
                else if (requestType == RequestType.Patch)
                {
                    response = await _httpClient.PatchAsync(uri, content);
                }
            }

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}