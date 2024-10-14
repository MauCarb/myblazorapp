using System.Net.Http.Json;
using BlazorApp.Shared;

public class LoginService
{
    private readonly HttpClient _httpClient;

    public LoginService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> AuthUser(string usr, string pwd)
    {
        return await _httpClient.GetFromJsonAsync<string>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/login/{usr}/{pwd}");
    }

    public async Task<string> AuthUser1(string cred)
    {
        return await _httpClient.GetStringAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/login/{cred}");
    }

    public async Task<string> Auth()
    {
        return await _httpClient.GetFromJsonAsync<string>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/login");
    }
}
