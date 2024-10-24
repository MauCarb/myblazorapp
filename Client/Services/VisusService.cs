using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using BlazorApp.Shared;

public class VisusService
{
    private readonly HttpClient _httpClient;

    public VisusService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Misure> GetVisus(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Misure>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visus/{id}");
    }

    public async Task AddVisus(Misure visus)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visus", visus);
    }

    public async Task UpdVisus(decimal id, Misure visus)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visus/{visus.IdMisura}", visus);
    }
}
