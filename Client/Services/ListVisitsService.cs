using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using BlazorApp.Shared;

public class ListVisitsService
{
    private readonly HttpClient _httpClient;

    public ListVisitsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CoppiaDecDat>> ListPatientsVisits(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<List<CoppiaDecDat>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/listvisits/{id}");
    }
}
