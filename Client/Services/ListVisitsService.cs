using BlazorApp.Shared;
using System.Net.Http.Json;

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
