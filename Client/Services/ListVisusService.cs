using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using BlazorApp.Shared;

public class ListVisusService
{
    private readonly HttpClient _httpClient;

    public ListVisusService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CoppiaDecDat>> ListPatientsVisus(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<List<CoppiaDecDat>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/listvisus/{id}");
    }
}
