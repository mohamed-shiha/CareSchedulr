using System.Net.Http.Json;

namespace CareSchedulr.Client.Services
{
    public class AuthenticationService
    {
        private readonly HttpClient _httpClient;

        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", new { username, password });
            return response.IsSuccessStatusCode;
        }

        public async Task LogoutAsync()
        {
            await _httpClient.PostAsync("api/auth/logout", null);
        }
    }

}
