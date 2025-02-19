using BlazorApp.Shared;
using System.Net.Http.Json;

public class FarmaciListService
{
    private readonly HttpClient _httpClient;

    public FarmaciListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Farmaci>> ListFarmaci(string far)
    {
        return await _httpClient.GetFromJsonAsync<List<Farmaci>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmacilst/{far}");
    }
}
