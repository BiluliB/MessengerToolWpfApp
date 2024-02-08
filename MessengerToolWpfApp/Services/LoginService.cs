using MessengerToolWpfApp.DTOs.Requests;
using MessengerToolWpfApp.DTOs.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class LoginService
{
    private readonly string _baseUrl = "https://localhost:7221";

    public async Task<string> LoginAsync(string username, string password)
    {
        var loginUrl = $"{_baseUrl}/api/user/authenticate";
        var loginModel = new UserLoginDTO { UserName = username, Password = password };
        var content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");

        using (var client = new HttpClient())
        {
            var response = await client.PostAsync(loginUrl, content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponseDto>(responseString);
                return loginResponse.Token; // Angenommen, deine API gibt ein Objekt mit einem Token zurück
            }
            else
            {
                throw new Exception("Login fehlgeschlagen");
            }
        }
    }
}
