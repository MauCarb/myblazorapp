using BlazorApp.Shared;
using System.Net.Http.Json;

public class ListOrtoctisService
{
    private readonly HttpClient _httpClient;

    public ListOrtoctisService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CoppiaDecDat>> ListPatientsOrtottica(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<List<CoppiaDecDat>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/listortoctis/{id}");
    }
}
