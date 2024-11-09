using BlazorApp.Shared;
using System.Net.Http.Json;

public class OrtoctisService
{
    private readonly HttpClient _httpClient;

    public OrtoctisService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Ortottica> GetOrtottica(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Ortottica>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/ortoctis/{id}");
    }

    public async Task AddOrtottica(Ortottica ortoctis)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/ortoctis", ortoctis);
    }

    public async Task UpdOrtottica(decimal id, Ortottica ortoctis)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/ortoctis/{ortoctis.IdOrtottica}", ortoctis);
    }
}
