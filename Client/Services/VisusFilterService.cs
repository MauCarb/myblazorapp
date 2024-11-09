using BlazorApp.Shared;
using System.Net.Http.Json;

public class VisusFilterService
{
    private readonly HttpClient _httpClient;

    public VisusFilterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<FiltroMisure>> VisusList(string p)
    {
        return await _httpClient.GetFromJsonAsync<List<FiltroMisure>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/filtervisus/{p}");
    }
}
