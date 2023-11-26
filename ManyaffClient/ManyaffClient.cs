using ManyaffClient.Responses;
using System.Security.Cryptography;
using System.Text.Json;

namespace ManyaffClient
{
    public class ManyaffClient
    {
        private readonly HttpClient httpClient = new();

        public ManyaffClient()
        {

        }



        public async Task<LoginResponse> GetLoginResponse(User user)
        {
            string url = "https://api.manyaff.com/admin/v1/login";

            string json = JsonSerializer.Serialize(user);

            StringContent content = new(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, url) { Content = content });

            string contentString = await response.Content.ReadAsStringAsync();
            LoginResponse loginResponse = JsonSerializer.Deserialize<LoginResponse>(contentString);
            return loginResponse;
        }

        public async Task<DashboardReponse> GetUserDashboard(User user, DateTime startDate, DateTime endDate)
        {
            string url = $"https://api.manyaff.com/api/v1/dashboard_pub?date_range=[%22{startDate:yyyy-MM-dd}%22,%22{endDate:yyyy-MM-dd}%22]";

            LoginResponse loginResponse = await GetLoginResponse(user);
            string token = loginResponse.Data.Token;

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Access-Token", token);

            HttpResponseMessage response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, url));

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return new DashboardReponse { Success = false };
            }

            string contentString = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            DashboardReponse dashboardReponse = JsonSerializer.Deserialize<DashboardReponse>(contentString, options);

            if (dashboardReponse.Success)
            {
                return dashboardReponse;
            }

            return new DashboardReponse { Success = false };
        }
    }
}
